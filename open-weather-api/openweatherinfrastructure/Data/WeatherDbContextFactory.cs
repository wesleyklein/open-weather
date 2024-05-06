using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace OpenWeather.Infrastructure.Data
{
    public class WeatherDbContextFactory : IDesignTimeDbContextFactory<WeatherDbContext>
    {
        public WeatherDbContext CreateDbContext(string[] args)
        {
            // Define o caminho para o diretório do projeto onde o appsettings.json está localizado.
            var basePath = Directory.GetCurrentDirectory();
            if (Directory.EnumerateFiles(basePath, "*.csproj").Any())
            {
                basePath = Path.GetDirectoryName(basePath);  // Move up one directory if current directory isn't the project directory.
            }

            // Define the path to the appsettings.json file
            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Development";

            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: true)
                .AddJsonFile($"appsettings.{environmentName}.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            var builder = new DbContextOptionsBuilder<WeatherDbContext>();
            var connectionString = configuration.GetConnectionString("WeatherDbConnection");
            builder.UseSqlite(connectionString);

            return new WeatherDbContext(builder.Options);
        }
    }
}