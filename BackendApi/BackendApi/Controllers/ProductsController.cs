using BackendApi.data;
using BackendApi.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IConnectionMultiplexer _redis;

        public ProductsController(DataContext context, IConnectionMultiplexer redis)
        {
            _context = context;
            _redis = redis;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetAllProducts()
        {
            var cacheKey = "Products";
            var db = _redis.GetDatabase();

            // Step 1: Try to get products from Redis cache
            var cachedProducts = await db.StringGetAsync(cacheKey);
            if (cachedProducts.HasValue)
            {
                var productsFromCache = JsonConvert.DeserializeObject<List<Products>>(cachedProducts);
                return Ok(productsFromCache); // Serve cached products
            }

            // Step 2: Try to fetch products from the database
            List<Products> productsFromDb = null;
            try
            {
                productsFromDb = await _context.Products.OrderBy(e => e.Id).ToListAsync();

                // Step 3: If successful, cache the data in Redis
                var serializedProducts = JsonConvert.SerializeObject(productsFromDb);
                await db.StringSetAsync(cacheKey, serializedProducts, TimeSpan.FromMinutes(10)); // Set cache expiration time
            }
            catch (Exception ex)
            {
                // Log the error (optional) - e.g. "Database connection failed"

                // Step 4: If DB is down and Redis has no data, return an error
                if (!cachedProducts.HasValue)
                {
                    return StatusCode(500, "Database is down, and no cached data is available.");
                }

                // Step 5: Return data from Redis if DB is down but cache exists
                return Ok(JsonConvert.DeserializeObject<List<Products>>(cachedProducts));
            }

            // Step 6: Return products from DB if successful
            return Ok(productsFromDb);
        }
    }
}
