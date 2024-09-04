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

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] Customer customer)
        {
            Console.WriteLine($"Login attempt for email: {customer.email}");

            var user = await _context.Customers
                .FirstOrDefaultAsync(c => c.email == customer.email);

            if (user == null)
            {
                Console.WriteLine("User not found");
                return Unauthorized("Nieprawidłowy email lub hasło");
            }

            if (!VerifyPassword(customer.password, user.password))
            {
                Console.WriteLine("Invalid password");
                return Unauthorized("Nieprawidłowy email lub hasło");
            }
            return Ok(customer);
            //var token = GenerateJwtToken(user);
            //Console.WriteLine("Login successful, token generated");
            //return Ok(new { token });
        }

        private string GenerateJwtToken(Customer user)
        {
            // Get the secret key and expiration time from the configuration
            var secretKey = _configuration["Jwt:Key"];
            var expirationInMinutes = int.Parse(_configuration["Jwt:DurationInMinutes"]);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.id.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.email),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(expirationInMinutes),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
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