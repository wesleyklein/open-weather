using Microsoft.Extensions.DependencyInjection;
using OpenWeather.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeather.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<WeatherDataService, WeatherDataService>();
            // Adicione outras dependências específicas da camada de aplicação aqui

            return services;
        }
    }
}
