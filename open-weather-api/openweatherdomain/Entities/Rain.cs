using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OpenWeather.Domain.Entities
{
    public class Rain
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public double? _1h { get; set; }

        public long? CurrentWeatherId { get; set; }
        [ForeignKey(nameof(CurrentWeatherId))]
        [InverseProperty(nameof(CurrentWeather.Rain))]
        public CurrentWeather? CurrentWeatherIdNavigation { get; set; }

        public long? HourlyForecastId { get; set; }
        [ForeignKey(nameof(HourlyForecastId))]
        [InverseProperty(nameof(HourlyForecast.Rain))]
        public HourlyForecast? HourlyForecastIdNavigation { get; set; }
    }
}
