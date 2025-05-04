using System.Text.Json;
using sky_webapi.DTOs;

namespace sky_webapi.Services
{
    public interface IWeatherService
    {
        Task<WeatherForecastDto> GetCurrentWeatherAsync();
    }

    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly string _apiKey;
        private const string MAYFIELD_LAT = "51.0224";
        private const string MAYFIELD_LON = "0.2580";

        public WeatherService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _apiKey = _configuration["OpenWeatherMap:ApiKey"] ?? throw new InvalidOperationException("OpenWeatherMap API key is not configured");
        }

        public async Task<WeatherForecastDto> GetCurrentWeatherAsync()
        {
            var url = $"https://api.openweathermap.org/data/2.5/weather?lat={MAYFIELD_LAT}&lon={MAYFIELD_LON}&appid={_apiKey}&units=metric";
            
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            
            var content = await response.Content.ReadAsStringAsync();
            var weatherData = JsonSerializer.Deserialize<JsonElement>(content);

            return new WeatherForecastDto
            {
                Temperature = weatherData.GetProperty("main").GetProperty("temp").GetDouble(),
                FeelsLike = weatherData.GetProperty("main").GetProperty("feels_like").GetDouble(),
                Humidity = weatherData.GetProperty("main").GetProperty("humidity").GetInt32(),
                Description = weatherData.GetProperty("weather")[0].GetProperty("description").GetString(),
                Icon = weatherData.GetProperty("weather")[0].GetProperty("icon").GetString(),
                WindSpeed = weatherData.GetProperty("wind").GetProperty("speed").GetDouble()
            };
        }
    }
}