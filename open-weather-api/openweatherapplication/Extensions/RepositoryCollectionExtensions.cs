using Microsoft.Extensions.DependencyInjection;
using OpenWeather.Application.Services;
using OpenWeather.Domain.Interfaces;
using OpenWeather.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeather.Application.Extensions
{
    public static class RepositoryCollectionExtensions
    {
        public static IServiceCollection AddApplicationRepository(this IServiceCollection services)
        {
            services.AddScoped<IWeathertDataRepository, WeathertDataRepository>();
            // Adicione outras dependências específicas da camada de aplicação aqui

            return services;
        }
    }
}
