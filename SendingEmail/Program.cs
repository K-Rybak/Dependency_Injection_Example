using SendingEmail.Interfaces;
using SendingEmail.Model;
using SendingEmail.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//DI
//builder.Services.AddEmailSender();
builder.Services.AddScoped<IEmailSender, EmailSender>();
builder.Services.AddScoped<MessageFactory>();
builder.Services.AddSingleton<NetworkClient>();
builder.Services.AddSingleton(
    new EmailServerSettings
    (
        host: "smtp.server.com",
        port: 25
    ));

//builder.Services.AddScoped(
//    provider =>
//        new EmailServerSettings
//        (
//            host: "smtp.server.com",
//            port: 25
//        ));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
