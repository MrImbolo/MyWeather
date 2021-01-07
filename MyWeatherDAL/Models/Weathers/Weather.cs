using MyWeatherDAL.JsonConverters;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MyWeatherDAL.Models.Weather
{
    public partial class Weather
    {
        public int Id { get; set; }
        [JsonConverter(typeof(UnixDateTimeJsonConverter))]
        public DateTime Sunrise { get; private set; }
        [JsonConverter(typeof(UnixDateTimeJsonConverter))]
        public DateTime Sunset { get; private set; }
        [JsonConverter(typeof(UnixDateTimeJsonConverter))]
        [JsonPropertyName("dt")]
        public DateTime DateTime { get; set; }

        public double Temp { get; set; }
        [JsonPropertyName("feels_like")]
        public double FeelsLike { get; set; }
        public long Pressure { get; set; }
        public long Humidity { get; set; }
        public double DewPoint { get; set; }
        public double Uvi { get; set; }
        public long Clouds { get; set; }
        public long Visibility { get; set; }
        [JsonPropertyName("wind_speed")]
        public double WindSpeed { get; set; }
        [JsonPropertyName("wind_deg")]
        public long WindDeg { get; set; }
        [JsonPropertyName("weather")]
        public List<WeatherDescription> WeatherDescription { get; set; }
    }
}
