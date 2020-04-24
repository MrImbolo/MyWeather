using System;

namespace MyWeatherDAL.Models
{
    public class Weather
    {
        public int Id { get; set; }

        public DateTime SunriseDT { get; private set; }
        public DateTime SunsetDT { get; private set; }
        public DateTime DateTime { get; set; }

        public double Temp { get; set; }
        public double FeelsLike { get; set; }
        public long Pressure { get; set; }
        public long Humidity { get; set; }
        public double DewPoint { get; set; }
        public double Uvi { get; set; }
        public long Clouds { get; set; }
        public long Visibility { get; set; }
        public long WindSpeed { get; set; }
        public long WindDeg { get; set; }
    }
}
