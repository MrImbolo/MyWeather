using System.Collections.Generic;

namespace MyWeatherDAL.Models.Weather
{
    public partial class WeatherSummary
    {
        public int Id { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Timezone { get; set; }
        public Weather Current { get; set; }
        public List<Weather> Hourly { get; set; }
        public List<DailyWeather> Daily { get; set; }
        public int LocationId { get; set; }
    }
}
