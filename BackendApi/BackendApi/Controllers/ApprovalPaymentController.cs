using BackendApi.data;
using BackendApi.models;
using Microsoft.AspNetCore.Mvc;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApprovalPaymentController : ControllerBase
    {
        private readonly DataContext _context;
        public ApprovalPaymentController(DataContext context)
        {
            _context = context;
        }

		[HttpGet]
		[ProducesResponseType(200)]
		[ProducesResponseType(500)]
		public IActionResult GetAllApprovalPayments(){
			try{
				var approvalPayments = _context.ApprovalPayment.OrderBy(e=>e.Id).ToList();
				return Ok(approvalPayments);
			}
			catch(Exception ex){
				return StatusCode(500, ex.Message);
			}
		}
		[HttpDelete("{id}")]
		[ProducesResponseType(200)]
		[ProducesResponseType(500)]
		public IActionResult DeleteApprovalPayment(int id){
			try{
				var approvalPayment = _context.ApprovalPayment.Find(id);
				if(approvalPayment == null){
					return NotFound();
				}
				_context.ApprovalPayment.Remove(approvalPayment);
				_context.SaveChanges();
				return NoContent();
			}
			catch(Exception ex){
				return StatusCode(500, ex.Message);
			}
		}
		[HttpPost]
		[ProducesResponseType(200)]
		[ProducesResponseType(500)]
		public IActionResult CreateApprovalPayment(ApprovalPayment approvalPayment){
			try{
				_context.ApprovalPayment.Add(approvalPayment);
				_context.SaveChanges();
				return CreatedAtAction(nameof(GetAllApprovalPayments), new { id = approvalPayment.Id }, approvalPayment);
			}
			catch(Exception ex){
				return StatusCode(500, ex.Message);
			}
		}
    }
}