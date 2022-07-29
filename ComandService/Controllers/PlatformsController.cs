using Microsoft.AspNetCore.Mvc;

namespace ComandService.Controllers
{
    [Route("/api/c/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {
            
        }
        [HttpPost]
        public ActionResult TestInboundConnection() {
            System.Console.WriteLine("--> inbound POST # Command Service");

            return Ok("Inbound test ok from Platforms Controller");

        }
    }
}