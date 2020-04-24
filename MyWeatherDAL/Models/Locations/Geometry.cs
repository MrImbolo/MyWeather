namespace MyWeatherDAL.Models.Locations
{
    using System.Text.Json.Serialization;

    public partial class Geometry
    {
        public int Id { get; set; }

        [JsonPropertyName("lat")]
        public double Lat { get; set; }

        [JsonPropertyName("lng")]
        public double Lng { get; set; }
    }
}
