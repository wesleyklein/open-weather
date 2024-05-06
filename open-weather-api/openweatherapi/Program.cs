using Microsoft.EntityFrameworkCore;
using OpenWeather.Infrastructure.Configuration;
using OpenWeather.Application.Extensions;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Configuração do Kestrel
builder.WebHost.ConfigureKestrel(serverOptions =>
{
    // Configura o servidor para ouvir nas portas especificadas
    serverOptions.Listen(IPAddress.Any, 5000, listenOptions =>
    {
        // Configurações adicionais para HTTP podem ser colocadas aqui
    });

    serverOptions.Listen(IPAddress.Any, 5001, listenOptions =>
    {
        // Configurações para HTTPS
        listenOptions.UseHttps("cert/development_certificate.pfx", "123456");
    });
});

// Add services to the container.
builder.Logging.ClearProviders(); // Limpa os provedores padrões
builder.Logging.AddConsole(); // Adiciona o provedor de console

var connectionString = builder.Configuration.GetConnectionString("WeatherDbConnection");
builder.Services.AddInfrastructureServices(connectionString);

builder.Services.AddHttpClient();
builder.Services.AddApplicationRepository();
builder.Services.AddApplicationServices();

// Configure JSON serialization options
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
});



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "OpenWeather API",
        Version = "v1",
        Description = "Current & Forecast weather data collection",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Name = "Wesley Klein",
            Email = "wesleymga@gmail.com"
        }
    });
    // Configure Swagger to use the XML comments from the generated file
    var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "OpenWeather API V1");
        c.RoutePrefix = string.Empty;  // Serve the Swagger UI at the app's root
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
