using SendingEmail.Model;

namespace SendingEmail.Services
{
    public class MessageFactory
    {
        public Email Create(string emailAddress)
        {
            return new Email
            {
                Address = emailAddress,
                Message = "Thanks for sign up"
            };
        }
    }
}
