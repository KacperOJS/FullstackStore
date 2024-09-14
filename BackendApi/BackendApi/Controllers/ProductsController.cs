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
    public class ProductsController:ControllerBase
    {
        private readonly DataContext _context;
        private readonly IConnectionMultiplexer _redis;
        
        public ProductsController(DataContext context,IConnectionMultiplexer redis)
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
            var cachedProducts= await db.StringGetAsync(cacheKey);
            if (cachedProducts.HasValue)
            {
                var products = JsonConvert.DeserializeObject<List<Products>>(cachedProducts);
                return Ok(products);
            }
            var productsFromDb = await _context.Products.OrderBy(e => e.Id).ToListAsync();

            // Serialize products and store in cache with an expiration time
            var serializedProducts = JsonConvert.SerializeObject(productsFromDb);
            await db.StringSetAsync(cacheKey, serializedProducts, TimeSpan.FromMinutes(10)); // Cache expiration time

            return Ok(productsFromDb);
        }


    }
}
