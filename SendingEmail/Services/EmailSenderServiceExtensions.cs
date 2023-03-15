using SendingEmail.Interfaces;
using SendingEmail.Model;

namespace SendingEmail.Services
{
    public static class EmailSenderServiceExtensions
    {
        public static IServiceCollection AddEmailSender(this IServiceCollection services)
        {
            services.AddScoped<IEmailSender, EmailSender>();
            services.AddScoped<MessageFactory>();
            services.AddSingleton<NetworkClient>();
            services.AddSingleton(
                new EmailServerSettings
                (
                    host: "smtp.server.com",
                    port: 25
                ));
            return services;
        }
    }
}
