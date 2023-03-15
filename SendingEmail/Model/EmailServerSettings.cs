namespace SendingEmail.Model
{
    public class EmailServerSettings
    {
        public EmailServerSettings(string host, int port)
        {
            Host = host;
            Port = port;
        }

        public string Host { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
