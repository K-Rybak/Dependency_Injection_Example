using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SendingEmail.Services;
using SendingEmail.Model;

namespace SendingEmail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly EmailSender _emailSender;
        public UserController(EmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [HttpPost("register")]
        public IActionResult RegisterUser(string username)
        {
            _emailSender.SendEmail(username);
            return Ok();
        }
    }
}
