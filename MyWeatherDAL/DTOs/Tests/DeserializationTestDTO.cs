using System.Text.Json.Serialization;

namespace MyWeatherDAL.DTOs.Tests
{
    public class DeserializationTestDTO
    {
        [JsonPropertyName("json")]
        public string Json { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
