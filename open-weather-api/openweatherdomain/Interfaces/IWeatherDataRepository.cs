using OpenWeather.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeather.Domain.Interfaces
{
    public interface IWeathertDataRepository
    {
        void AddWeatherDataAsync(WeatherData weathert);
        IEnumerable<WeatherData> GetAllWeathertDataAsync();
    }
}
