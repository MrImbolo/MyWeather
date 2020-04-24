namespace MyWeatherDAL.Models.Locations
{
    using System.Text.Json.Serialization;

    public partial class Sun
    {
        public int Id { get; set; }

        [JsonPropertyName("rise")]
        public Rise Rise { get; set; }

        [JsonPropertyName("set")]
        public Rise Set { get; set; }
    }
}
