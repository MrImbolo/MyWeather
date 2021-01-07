using Microsoft.EntityFrameworkCore;
using MyWeatherDAL.JsonConverters;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MyWeatherDAL.Models.Weather
{
    public partial class Temp
    {
        [Key]
        public int Id { get; set; }

        [JsonPropertyName("day")]
        [JsonConverter(typeof(DoubleToStringConverter))]
        public double Day { get; set; }

        [JsonPropertyName("min")]
        [JsonConverter(typeof(DoubleToStringConverter))]
        public double Min { get; set; }

        [JsonPropertyName("max")]
        [JsonConverter(typeof(DoubleToStringConverter))]
        public double Max { get; set; }

        [JsonPropertyName("night")]
        [JsonConverter(typeof(DoubleToStringConverter))]
        public double Night { get; set; }

        [JsonPropertyName("eve")]
        [JsonConverter(typeof(DoubleToStringConverter))]
        public double Eve { get; set; }

        [JsonPropertyName("morn")]
        [JsonConverter(typeof(DoubleToStringConverter))]
        public double Morn { get; set; }
    }
}
