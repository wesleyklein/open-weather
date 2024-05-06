using Microsoft.AspNetCore.Mvc;
using OpenWeather.Application.Services;
//using Swashbuckle.AspNetCore.Annotations;

namespace OpenWeatherApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherDataController : ControllerBase
{
    private readonly ILogger<WeatherDataController> _logger;
    private readonly WeatherDataService _weatherForecastService;
    

    public WeatherDataController(ILogger<WeatherDataController> logger,
        WeatherDataService weatherForecastService
        )
    {
        _logger = logger;
        _weatherForecastService = weatherForecastService;
    }

    /// <summary>
    /// Retrieves the weather forecast data.
    /// </summary>
    /// <param name="lat">Latitude, decimal (-90; 90).</param>
    /// <param name="lon">Longitude, decimal (-180; 180).</param>
    /// <param name="exclude">Parts of the weather data to exclude. Comma-delimited list: current, minutely, hourly, daily, alerts.</param>
    /// <param name="units">Units of measurement. Options: standard, metric, imperial. Default is standard.</param>
    /// <param name="lang">Language of the output. Default is English.</param>
    /// <returns>Returns weather data based on parameters provided.</returns>
    /// <response code="200">Returns the weather forecast data.</response>
    /// <response code="400">If the request parameters are invalid.</response>
    /// <response code="404">Product not found</response>
    /// <response code="500">Oops! Can't lookup your product right now</response>
    [HttpGet(Name = "GetCurrentForecastsWeatherData")]
    public IActionResult GetCurrentForecastsWeatherData([FromQuery] decimal lat, [FromQuery] decimal lon, [FromQuery] string exclude = null, [FromQuery] string units = "standard", [FromQuery] string lang = "pt_br")
    {
        try
        {
            var returnService = _weatherForecastService.FetchAndStoreWeatherData(lat, lon, exclude, units, lang);
            return Ok(returnService);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error GetCurrentForecastsWeatherData");
            return BadRequest(ex);
        }

        
    }
}
