namespace SendingEmail.Services
{
    public class EmailSender
    {
        public void SendEmail(string username)
        {
            Console.WriteLine($"Email sent to {username}");
        }
    }
}
