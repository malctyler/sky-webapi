using System.Text.Json;
using sky_webapi.DTOs;

namespace sky_webapi.Services
{
    public interface IWeatherService
    {
        Task<WeatherForecastDto> GetCurrentWeatherAsync();
        Task<WeatherForecastDetailDto> GetFiveDayForecastAsync();
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
                Humidity = weatherData.GetProperty("main").GetProperty("humidity").GetInt32(),                Description = weatherData.GetProperty("weather")[0].GetProperty("description").GetString() ?? "Unknown",
                Icon = weatherData.GetProperty("weather")[0].GetProperty("icon").GetString() ?? "unknown",
                WindSpeed = weatherData.GetProperty("wind").GetProperty("speed").GetDouble()
            };
        }

        public async Task<WeatherForecastDetailDto> GetFiveDayForecastAsync()
        {
            var url = $"https://api.openweathermap.org/data/2.5/forecast?lat={MAYFIELD_LAT}&lon={MAYFIELD_LON}&appid={_apiKey}&units=metric";
            
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            
            var content = await response.Content.ReadAsStringAsync();
            var forecastData = JsonSerializer.Deserialize<JsonElement>(content);

            var forecast = new WeatherForecastDetailDto
            {
                Items = new List<ForecastItem>(),
                City = new CityInfo
                {                    Name = forecastData.GetProperty("city").GetProperty("name").GetString() ?? "Unknown",
                    Country = forecastData.GetProperty("city").GetProperty("country").GetString() ?? "Unknown",
                    Sunrise = forecastData.GetProperty("city").GetProperty("sunrise").GetInt64(),
                    Sunset = forecastData.GetProperty("city").GetProperty("sunset").GetInt64(),
                    Coord = new Coordinates
                    {
                        Lat = forecastData.GetProperty("city").GetProperty("coord").GetProperty("lat").GetDouble(),
                        Lon = forecastData.GetProperty("city").GetProperty("coord").GetProperty("lon").GetDouble()
                    }
                }
            };

            var list = forecastData.GetProperty("list");
            foreach (var item in list.EnumerateArray())
            {                forecast.Items.Add(new ForecastItem
                {
                    DateTime = item.GetProperty("dt").GetInt64(),
                    DtTxt = item.GetProperty("dt_txt").GetString() ?? "Unknown",
                    Pop = item.GetProperty("pop").GetDouble(),
                    Main = new MainWeather
                    {
                        Temp = item.GetProperty("main").GetProperty("temp").GetDouble(),
                        FeelsLike = item.GetProperty("main").GetProperty("feels_like").GetDouble(),
                        TempMin = item.GetProperty("main").GetProperty("temp_min").GetDouble(),
                        TempMax = item.GetProperty("main").GetProperty("temp_max").GetDouble(),
                        Pressure = item.GetProperty("main").GetProperty("pressure").GetInt32(),
                        Humidity = item.GetProperty("main").GetProperty("humidity").GetInt32()
                    },
                    Weather = item.GetProperty("weather").EnumerateArray().Select(w => new Weather
                    {
                        Id = w.GetProperty("id").GetInt32(),
                        Main = w.GetProperty("main").GetString() ?? "Unknown",
                        Description = w.GetProperty("description").GetString() ?? "Unknown",
                        Icon = w.GetProperty("icon").GetString() ?? "unknown"
                    }).ToList(),
                    Wind = new Wind
                    {
                        Speed = item.GetProperty("wind").GetProperty("speed").GetDouble(),
                        Deg = item.GetProperty("wind").GetProperty("deg").GetInt32(),
                        Gust = item.GetProperty("wind").TryGetProperty("gust", out var gust) ? gust.GetDouble() : 0
                    }
                });
            }

            return forecast;
        }
    }
}