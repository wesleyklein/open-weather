using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using OpenWeather.Domain.Converters;

namespace OpenWeather.Domain.Entities
{
    public class Alert
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string SenderName { get; set; }
        public string Event { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Start { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime End { get; set; }
        public string Description { get; set; }
        public List<string> Tags { get; set; }
        public long? WeatherDataId { get; set; }
        [ForeignKey(nameof(WeatherDataId))]
        [InverseProperty(nameof(WeatherData.Alerts))]
        public WeatherData? WeatherDataIdNavigation { get; set; }
    }
}
