using Microsoft.AspNetCore.Mvc;

namespace VulnerableSite.Controllers
{
    [ApiController]
    [Route("appsec")]
    public class AppSecDemoController : ControllerBase
    {
        [HttpGet("hello")]
        public IActionResult Hello()
        {
            return Ok("AppSec Demo");
        }
    }
}
