using BackendApi.data;
using BackendApi.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;
        public CustomerController(DataContext context,IConfiguration configuration)
        {
            _context = context;
            _configuration= configuration;
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
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> CreateCustomer([FromBody] Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                // Sprawdzenie, czy nazwa jest już zajęta
                var existingCustomerWithName = await _context.Customers
                    .FirstOrDefaultAsync(c => c.name == customer.name);
                if (existingCustomerWithName != null)
                {
                    return BadRequest("Nazwa użytkownika jest już zajęta");
                }

                // Sprawdzenie, czy email jest już zajęty
                var existingCustomerWithEmail = await _context.Customers
                    .FirstOrDefaultAsync(c => c.email == customer.email);
                if (existingCustomerWithEmail != null)
                {
                    return BadRequest("Adres email jest już zajęty");
                }
                customer.password = HashPassword(customer.password);


                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();
                return Ok(customer);
            }
            catch (Exception ex)
            {

                return StatusCode(500, "Wystąpił wewnętrzny błąd serwera");
            }
        }
        //private string GenerateJwtToken(Customer customer)
        //{
        //    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("miska"));
        //    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        //    var token = new JwtSecurityToken(
        //        issuer: "rysiek",
        //        audience: "dawid",
        //        claims: new List<Claim>(),
        //        expires: DateTime.Now.AddMinutes(30),
        //        signingCredentials: creds);

        //    return new JwtSecurityTokenHandler().WriteToken(token);
        //}

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] Customer customer)
        {
            try
            {
                Console.WriteLine($"Login attempt for email: {customer.email}");

                // Fetch the user by email
                var user = await _context.Customers.FirstOrDefaultAsync(c => c.email == customer.email);
       
                if (user == null)
                {
                    Console.WriteLine("User not found");
                    return Unauthorized(new { message = "Nieprawidłowy email lub hasło" });
                }

                // Hash the input password and compare it with the stored hashed password
                string hashedInputPassword = HashPassword(customer.password);

                if (hashedInputPassword != user.password) 
                { 
                    Console.WriteLine("Invalid password");
                    return Unauthorized(new { message = "Nieprawidłowy email lub hasło" });
                }

                // If login is successful
                //var token = GenerateJwtToken(user);
                Console.WriteLine("Login successful");
                return Ok(new { message = "Zalogowano pomyślnie", userId = user.id, CustomerName= user.name,CustomerEmail=user.email });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Login: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                return StatusCode(500, new { message = "Wystąpił wewnętrzny błąd serwera" });
            }
        }

  


        private bool VerifyPassword(string inputPassword, string storedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(inputPassword, storedPassword);
        }


        private string? HashPassword(string? password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }





        [HttpPut("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateCustomer(int id, [FromBody] Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var existingCustomer = await _context.Customers.FindAsync(id);
                if (existingCustomer == null)
                {
                    return NotFound("Customer not found");
                }

                // Update fields
                existingCustomer.name = customer.name ?? existingCustomer.name;
                existingCustomer.email = customer.email ?? existingCustomer.email;
                existingCustomer.phone = customer.phone ?? existingCustomer.phone;

                // Only update the password if it's provided
                if (!string.IsNullOrEmpty(customer.password))
                {
                    existingCustomer.password = HashPassword(customer.password);
                }

                await _context.SaveChangesAsync();

                return Ok(existingCustomer);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Wystąpił wewnętrzny błąd serwera", details = ex.Message });
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