using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OpenWeather.Domain.Entities
{
    public class Temperature
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public double Day { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public double Night { get; set; }
        public double Eve { get; set; }
        public double Morn { get; set; }
        public long? DailyForecastId { get; set; }
        [ForeignKey(nameof(DailyForecast))]
        [InverseProperty(nameof(DailyForecast.Temp))]
        public DailyForecast? DailyForecastIdNavigation { get; set; }
    }
}
