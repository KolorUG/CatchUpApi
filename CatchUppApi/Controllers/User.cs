using Microsoft.AspNetCore.Mvc;

namespace CatchUppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class User : ControllerBase
    {
        public ActionResult Login([FromBody]string login, string password)
        {
            

            return Ok();
        }
    }
}