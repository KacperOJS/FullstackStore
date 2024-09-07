using BackendApi.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController:ControllerBase
    {
        private readonly DataContext _context;
        
        public ProductsController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public IActionResult GetAllProducts()
        {
            var Products = _context.Products.OrderBy(e => e.Id).ToList();
            return Ok(Products);
        }


    }
}
