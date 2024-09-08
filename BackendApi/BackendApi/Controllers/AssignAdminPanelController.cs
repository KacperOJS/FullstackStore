using BackendApi.data;
using Microsoft.AspNetCore.Mvc;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignAdminPanelController:ControllerBase
    {
        private readonly DataContext _context;

        public AssignAdminPanelController(DataContext context)
        {
            _context = context;
        }
        [HttpGet("GetAdmin")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult GetAdminClient()
        {
            var GetAllAdminClients = _context.Customers.ToList();
            return Ok(GetAllAdminClients);
        }


    }
}
