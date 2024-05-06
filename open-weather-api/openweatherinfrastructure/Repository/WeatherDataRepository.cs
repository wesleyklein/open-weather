using Microsoft.EntityFrameworkCore;
using OpenWeather.Domain.Entities;
using OpenWeather.Domain.Interfaces;
using OpenWeather.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeather.Infrastructure.Repository
{
    public class WeathertDataRepository : IWeathertDataRepository
    {
        private readonly WeatherDbContext _context;

        public WeathertDataRepository(WeatherDbContext context)
        {
            _context = context;
        }

        public void AddWeatherDataAsync(WeatherData weathertData)
        {
            _context.Instance.Add(weathertData);
            _context.SaveChanges();
        }

        public IEnumerable<WeatherData> GetAllWeathertDataAsync()
        {
            return _context.WeatherData.ToList();
        }


    }

}
