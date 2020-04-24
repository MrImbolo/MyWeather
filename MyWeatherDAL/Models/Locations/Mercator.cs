namespace MyWeatherDAL.Models.Locations
{
    using System.Text.Json.Serialization;

    public partial class Mercator
    {
        public int Id { get; set; }

        [JsonPropertyName("x")]
        public double X { get; set; }

        [JsonPropertyName("y")]
        public double Y { get; set; }
    }
}
