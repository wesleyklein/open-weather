using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using OpenWeather.Domain.Converters;

namespace OpenWeather.Domain.Entities
{
    public class CurrentWeather
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
        public double Temp { get; set; }
        public double FeelsLike { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public double DewPoint { get; set; }
        public double Uvi { get; set; }
        public int Clouds { get; set; }
        public int Visibility { get; set; }
        public double WindSpeed { get; set; }
        public int WindDeg { get; set; }
        public double? WindGust { get; set; }
        public Rain Rain { get; set; }
        public Snow Snow { get; set; }
        public List<Weather> Weather { get; set; }
        public long? WeatherDataId { get; set; }
        [ForeignKey(nameof(WeatherDataId))]
        [InverseProperty(nameof(WeatherData.Current))]
        public WeatherData? WeatherDataIdNavigation { get; set; }
    }
}
