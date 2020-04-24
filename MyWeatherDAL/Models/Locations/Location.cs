namespace MyWeatherDAL.Models.Locations
{
    using System.Text.Json.Serialization;

    public partial class Location
    {
        public int Id { get; set; }

        [JsonPropertyName("annotations")]
        public Annotations Annotations { get; set; }

        [JsonPropertyName("components")]
        public Components Components { get; set; }

        [JsonPropertyName("confidence")]
        public long Confidence { get; set; }

        [JsonPropertyName("formatted")]
        public string Formatted { get; set; }

        [JsonPropertyName("geometry")]
        public Geometry Geometry { get; set; }
    }
}
