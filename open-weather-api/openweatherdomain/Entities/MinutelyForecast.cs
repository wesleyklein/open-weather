using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using OpenWeather.Domain.Converters;

namespace OpenWeather.Domain.Entities
{
    public class MinutelyForecast
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Dt { get; set; }
        public int Precipitation { get; set; }
        public long? WeatherDataId { get; set; }
        [ForeignKey(nameof(WeatherDataId))]
        [InverseProperty(nameof(WeatherData.Minutely))]
        public WeatherData? WeatherDataIdNavigation { get; set; }
    }
}
