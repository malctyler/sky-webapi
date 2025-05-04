namespace sky_webapi.DTOs
{
    public class WeatherForecastDto
    {
        public double Temperature { get; set; }
        public double FeelsLike { get; set; }
        public int Humidity { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public double WindSpeed { get; set; }
    }
}