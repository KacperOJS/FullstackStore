using BackendApi.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LogsController : ControllerBase
    {
        private readonly DataContext _context;
        public LogsController(DataContext context)
        {
            _context = context;
        }
        [HttpGet("paymentlogs")]
        public async Task<IActionResult> GetAllLogs()
        {
            var paymentLogs = _context.PaymentLog
         .Include(log => log.Customer) // Assuming Customer is a navigation property
         .ToList();
            return Ok(paymentLogs);

        }
    }
}
