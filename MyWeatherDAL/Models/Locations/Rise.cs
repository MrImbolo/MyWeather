namespace MyWeatherDAL.Models.Locations
{
    using System.Text.Json.Serialization;

    public partial class Rise
    {
        public int Id { get; set; }

        [JsonPropertyName("apparent")]
        public long Apparent { get; set; }

        [JsonPropertyName("astronomical")]
        public long Astronomical { get; set; }

        [JsonPropertyName("civil")]
        public long Civil { get; set; }

        [JsonPropertyName("nautical")]
        public long Nautical { get; set; }
    }
}
