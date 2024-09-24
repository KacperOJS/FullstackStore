using BackendApi.data;
using BackendApi.models;
using BackendApi.Models; // Ensure this namespace is correct for your Contact model
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly DataContext _context;

        public ContactController(DataContext context)
        {
            _context = context;
        }

        // Method to get all comments
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetAllNewComments()
        {
            try
            {
                var getAllComments = await _context.Contacts.ToListAsync();
                return Ok(getAllComments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Method to create a new contact
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> CreateNewComment([FromBody] Contact contact)
        {
            if (contact == null || string.IsNullOrWhiteSpace(contact.Name) || string.IsNullOrWhiteSpace(contact.Email) || string.IsNullOrWhiteSpace(contact.message))
            {
                return BadRequest("Invalid contact information.");
            }

            try
            {
                _context.Contacts.Add(contact);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetAllNewComments), new { id = contact.Id }, contact);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An internal server error occurred: " + ex.Message);
            }
        }

        // Method to delete a comment
        [HttpDelete("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> DeleteCurrentComment(int id)
        {
            try
            {
                var comment = await _context.Contacts.FindAsync(id);
                if (comment == null)
                {
                    return NotFound();
                }

                _context.Contacts.Remove(comment);
                await _context.SaveChangesAsync();

                return NoContent(); // No content response after successful deletion
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An internal server error occurred: " + ex.Message);
            }
        }
    }
}
