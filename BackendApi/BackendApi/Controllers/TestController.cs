using Microsoft.AspNetCore.Mvc;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly RedisCacheService _redisCacheService;

        public TestController(RedisCacheService redisCacheService)
        {
            _redisCacheService = redisCacheService;
        }

        [HttpGet("test")]
        public async Task<IActionResult> Test()
        {
            await _redisCacheService.SetCacheValueAsync("test-key", "test-value");
            var value = await _redisCacheService.GetCacheValueAsync("test-key");
            return Ok(new { value });
        }
    }

}
