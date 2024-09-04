using BackendApi.data;
using Microsoft.AspNetCore.Mvc;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly DataContext _context;
        public CustomerController(DataContext context)
        {
            _context = context;
        }
       
	   [HttpGet]
	   [ProducesResponseType(200)]
	   [ProducesResponseType(500)]
	   public IActionResult GetAllCustomers(){
		try{
			var customers =_context.Customers.OrderBy(e=>e.Id).ToList();
			return Ok(customers);
		}
		catch(Exception ex){
			return StatusCode(500, ex.Message);
		}
	   }

	   [HttpGet("{id}")]
	   [ProducesResponseType(200)]
	   [ProducesResponseType(500)]
	   public IActionResult GetCustomerById(int id){
		try{
			var customer = _context.customers.Where(e=>e.Id == id).FirstOrDefault();
			return Ok(customer);
		}
		catch(Exception ex){
			return StatusCode(500, ex.Message);
		}
	   }

	   [HttpPost]
	   
       
    }
}