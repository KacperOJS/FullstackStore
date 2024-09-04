using BackendApi.data;
using BackendApi.models;
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
			var customers =_context.Customers.OrderBy(e=>e.id).ToList();
			return Ok(customers);
		}
		catch(Exception ex){
			return StatusCode(500, ex.Message);
		}
	   }
	   
       [HttpPost]
	   [ProducesResponseType(200)]
	   [ProducesResponseType(500)]
	   public IActionResult CreateCustomer([FromBody] Customer customer){
		try{
			_context.Customers.Add(customer);
			_context.SaveChanges();
			return Ok(customer);
		}
		catch(Exception ex){
			return StatusCode(500, ex.Message);
		}
	   }

	   [HttpPut("{id}")]
	   [ProducesResponseType(200)]
	   [ProducesResponseType(500)]
	   public IActionResult UpdateCustomer(int id, [FromBody] Customer customer){
		try{
			var existingCustomer = _context.Customers.Where(e=>e.id == id).FirstOrDefault();
			if(existingCustomer == null){
				return NotFound("Customer not found");
			}
			existingCustomer.name = customer.name;
			existingCustomer.email = customer.email;
			existingCustomer.phone = customer.phone;
			_context.SaveChanges();			
			return Ok(existingCustomer);
		}
		catch(Exception ex){
			return StatusCode(500, ex.Message);
		}
	   }

	   [HttpDelete("{id}")]
	   [ProducesResponseType(200)]
	   [ProducesResponseType(500)]
	   public IActionResult DeleteCustomer(int id){
		try{
			var customerToDelete = _context.Customers.Where(e=>e.id == id).FirstOrDefault();
			if(customerToDelete == null){
				return NotFound("Customer not found");
			}
			_context.Customers.Remove(customerToDelete);		
			_context.SaveChanges();
			return Ok("Customer deleted successfully");
		}
		catch(Exception ex){
			return StatusCode(500, ex.Message);
		}
	   }

	   
    }
}