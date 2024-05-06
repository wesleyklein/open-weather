using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OpenWeather.Application.DTOs;
using OpenWeather.Application.Policy;
using OpenWeather.Common.Converters;
using OpenWeather.Domain.Entities;
using OpenWeather.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OpenWeather.Application.Services
{
    public class WeatherDataService
    {
        private readonly HttpClient _httpClient;
        private readonly IWeathertDataRepository _weatherDataRepository;
        private readonly ILogger<WeatherDataService> _logger;
        private readonly IConfiguration _configuration;

        public WeatherDataService(
            IConfiguration configuration,
            ILogger<WeatherDataService> logger,
            HttpClient httpClient, IWeathertDataRepository weatherDataRepository)
        {
            _httpClient = httpClient;
            _weatherDataRepository = weatherDataRepository;
            _logger = logger;
            _configuration = configuration;
        }

        public string RenameJsonProperties(string json)
        {
            using (JsonDocument document = JsonDocument.Parse(json))
            {
                JsonElement root = document.RootElement;
                using (var stream = new MemoryStream())
                {
                    using (var writer = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true }))
                    {
                        WriteElement(root, writer);
                    }
                    return Encoding.UTF8.GetString(stream.ToArray());
                }
            }
        }


        private void WriteElement(JsonElement element, Utf8JsonWriter writer)
        {
            switch (element.ValueKind)
            {
                case JsonValueKind.Object:
                    writer.WriteStartObject();
                    foreach (JsonProperty prop in element.EnumerateObject())
                    {
                        writer.WritePropertyName(SnakeCaseToPascalCase(prop.Name)); // Use your transformation function here
                        WriteElement(prop.Value, writer);
                    }
                    writer.WriteEndObject();
                    break;
                case JsonValueKind.Array:
                    writer.WriteStartArray();
                    foreach (JsonElement item in element.EnumerateArray())
                    {
                        WriteElement(item, writer);
                    }
                    writer.WriteEndArray();
                    break;
                default:
                    element.WriteTo(writer);
                    break;
            }
        }

        public static string SnakeCaseToPascalCase(string snakeCaseString)
        {
            return string.Concat(snakeCaseString.Split('_')
                .Select(word => word.Length > 0 ? char.ToUpperInvariant(word[0]) + word.Substring(1).ToLower() : ""));
        }

        public WeatherData FetchAndStoreWeatherData(
            decimal lat, decimal lon, string exclude = null, string units = "standard", string lang = "en"
            )
        {
            try
            {
                var apiKey = _configuration["ApplicationSettings:ApiKey"];
                var url = $"https://api.openweathermap.org/data/3.0/onecall?lat={lat}&lon={lon}&exclude={exclude}&appid={apiKey}";
                var response = _httpClient.GetAsync(url).Result;


                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = response.Content.ReadAsStringAsync().Result;
                    var apiError = JsonSerializer.Deserialize<ApiWeatherDataErrorResponse>(errorContent);

                    _logger.LogError("Error calling external API: {Message}", apiError?.Message);
                    throw new Exception($"API Error: {apiError?.Message}");
                }
                var content = response.Content.ReadAsStringAsync().Result;
                content = RenameJsonProperties(content);

                var options = new JsonSerializerOptions
                {
                    Converters = { new UnixDateTimeConverter() }
                };

                var weatherData = JsonSerializer.Deserialize<WeatherData>(content, options);

                if (weatherData != null)
                {
                    _weatherDataRepository.AddWeatherDataAsync(weatherData);
                    return weatherData;
                }
                return default;
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "HTTP request error while calling external API.");
                throw; 
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unexpected error while calling external API.");
                throw; 
            }
        }
    }
}
