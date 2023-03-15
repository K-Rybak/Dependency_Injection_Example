using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SendingEmail.Services;

namespace SendingEmail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost("register")]
        public IActionResult RegisterUser(string username)
        {
            var emailSender = new EmailSender();
            emailSender.SendEmail(username);
            return Ok();
        }
    }
}
