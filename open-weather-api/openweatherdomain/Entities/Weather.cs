using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OpenWeather.Domain.Entities
{
    public class Weather
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UniqueId { get; set; }
        public long Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public long? CurrentWeatherIdWeather { get; set; }
        [ForeignKey(nameof(CurrentWeatherIdWeather))]
        [InverseProperty(nameof(CurrentWeather.Weather))]
        public CurrentWeather? CurrentWeatherIdWeatherNavigation { get; set; }

        public long? WeatherIdDailyForecast { get; set; }
        [ForeignKey(nameof(WeatherIdDailyForecast))]
        [InverseProperty(nameof(DailyForecast.Weather))]
        public DailyForecast? WeatherIdDailyForecastNavigation { get; set; }

        public long? WeatherIdHourlyForecast { get; set; }
        [ForeignKey(nameof(WeatherIdHourlyForecast))]
        [InverseProperty(nameof(HourlyForecast.Weather))]
        public HourlyForecast? WeatherIdHourlyForecastNavigation { get; set; }
    }
}
