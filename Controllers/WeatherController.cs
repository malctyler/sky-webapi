using Microsoft.AspNetCore.Mvc;
using sky_webapi.Services;
using sky_webapi.DTOs;

namespace sky_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        public async Task<ActionResult<WeatherForecastDto>> GetCurrentWeather()
        {
            try
            {
                var forecast = await _weatherService.GetCurrentWeatherAsync();
                return Ok(forecast);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error fetching weather data: " + ex.Message);
            }
        }
    }
}