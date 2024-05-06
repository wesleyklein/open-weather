using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using OpenWeather.Domain.Converters;

namespace OpenWeather.Domain.Entities
{
    public class DailyForecast
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Dt { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Sunrise { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Sunset { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Moonrise { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Moonset { get; set; }
        public double MoonPhase { get; set; }
        public string Summary { get; set; }
        public Temperature Temp { get; set; }
        public FeelsLike FeelsLike { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public double DewPoint { get; set; }
        public double WindSpeed { get; set; }
        public int WindDeg { get; set; }
        public double? WindGust { get; set; }
        public List<Weather> Weather { get; set; }
        public int Clouds { get; set; }
        public double? Pop { get; set; }
        public double? Rain { get; set; }
        public double? Snow { get; set; }
        public double Uvi { get; set; }
        public long? WeatherDataId { get; set; }
        [ForeignKey(nameof(WeatherDataId))]
        [InverseProperty(nameof(WeatherData.Daily))]
        public WeatherData? WeatherDataIdNavigation { get; set; }
    }
}
