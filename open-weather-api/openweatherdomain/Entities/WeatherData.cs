using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeather.Domain.Entities
{
    public class WeatherData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Timezone { get; set; }
        public int TimezoneOffset { get; set; }
        public CurrentWeather Current { get; set; }
        public List<MinutelyForecast> Minutely { get; set; }
        public List<HourlyForecast> Hourly { get; set; }
        public List<DailyForecast> Daily { get; set; }
        public List<Alert> Alerts { get; set; }
    }
}
