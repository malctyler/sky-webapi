namespace sky_webapi.DTOs
{
    public class WeatherForecastDetailDto
    {
        public List<ForecastItem> Items { get; set; } = new();
        public CityInfo City { get; set; }
    }

    public class ForecastItem
    {
        public long DateTime { get; set; }
        public MainWeather Main { get; set; }
        public List<Weather> Weather { get; set; }
        public Wind Wind { get; set; }
        public double Pop { get; set; }
        public string DtTxt { get; set; }
    }

    public class MainWeather
    {
        public double Temp { get; set; }
        public double FeelsLike { get; set; }
        public double TempMin { get; set; }
        public double TempMax { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
    }

    public class Weather
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }

    public class Wind
    {
        public double Speed { get; set; }
        public int Deg { get; set; }
        public double Gust { get; set; }
    }

    public class CityInfo
    {
        public string Name { get; set; }
        public Coordinates Coord { get; set; }
        public string Country { get; set; }
        public long Sunrise { get; set; }
        public long Sunset { get; set; }
    }

    public class Coordinates
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
    }
}