using Microsoft.AspNetCore.Mvc;
using sky_webapi.Services;
using sky_webapi.DTOs;
using Microsoft.AspNetCore.Authorization;

namespace sky_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // Change from [Authorize(Roles = "Staff")] to [Authorize] to allow all authenticated users
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

        [HttpGet("forecast")]
        public async Task<ActionResult<WeatherForecastDetailDto>> GetFiveDayForecast()
        {
            try
            {
                var forecast = await _weatherService.GetFiveDayForecastAsync();
                return Ok(forecast);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error fetching forecast data: " + ex.Message);
            }
        }
    }
}