namespace MyWeatherDAL.Models.Locations
{
    using System.Text.Json.Serialization;

    public partial class What3Words
    {
        public int Id { get; set; }

        [JsonPropertyName("words")]
        public string Words { get; set; }
    }
}
