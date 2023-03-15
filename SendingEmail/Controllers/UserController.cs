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
        [HttpPost("register")]
        public IActionResult RegisterUser(string username)
        {
            var emailSender = new EmailSender(
                new MessageFactory(),
                new NetworkClient(
                    new EmailServerSettings
                    (
                        host: "smtp.server.com",
                        port: 25
                     ))
                );
            emailSender.SendEmail(username);
            return Ok();
        }
    }
}
