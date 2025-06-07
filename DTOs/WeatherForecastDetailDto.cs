namespace sky_webapi.DTOs
{    public class WeatherForecastDetailDto
    {
        public List<ForecastItem> Items { get; set; } = new();
        public required CityInfo City { get; set; }
    }

    public class ForecastItem
    {
        public long DateTime { get; set; }
        public required MainWeather Main { get; set; }
        public required List<Weather> Weather { get; set; } = new();
        public required Wind Wind { get; set; }
        public double Pop { get; set; }
        public required string DtTxt { get; set; }
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
        public required string Main { get; set; }
        public required string Description { get; set; }
        public required string Icon { get; set; }
    }

    public class Wind
    {
        public double Speed { get; set; }
        public int Deg { get; set; }
        public double Gust { get; set; }
    }

    public class CityInfo
    {
        public required string Name { get; set; }
        public required Coordinates Coord { get; set; }
        public required string Country { get; set; }
        public long Sunrise { get; set; }
        public long Sunset { get; set; }
    }

    public class Coordinates
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
    }
}