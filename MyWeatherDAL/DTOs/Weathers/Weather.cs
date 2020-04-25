using MyWeatherDAL.JsonConverters;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MyWeatherDAL.DTO.Weathers
{
    public partial class Weather
    {
        public int Id { get; set; }
        [JsonConverter(typeof(UnixDateTimeJsonConverter))]
        public DateTime SunriseDT { get; private set; }
        [JsonConverter(typeof(UnixDateTimeJsonConverter))]
        public DateTime SunsetDT { get; private set; }
        [JsonConverter(typeof(UnixDateTimeJsonConverter))]
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
        [JsonPropertyName("Weather")]
        public List<WeatherDescription> WeatherDescription { get; set; }
    }
}
