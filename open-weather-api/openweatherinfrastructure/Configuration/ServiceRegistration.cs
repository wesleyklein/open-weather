using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OpenWeather.Infrastructure.Data;
using OpenWeather.Infrastructure.Interceptor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeather.Infrastructure.Configuration
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<WeatherDbContext>(options =>
                options.UseSqlite(connectionString)
                // .AddInterceptors(new MyCommandInterceptor()) //Log
               //.EnableSensitiveDataLogging() // Habilita o log de dados sensíveis
               //.LogTo(Console.WriteLine, LogLevel.Information) // Loga no console
               ); 
            
            return services;
        }
    }
}
