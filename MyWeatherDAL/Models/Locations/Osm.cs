namespace MyWeatherDAL.Models.Locations
{
    using System;
    using System.Text.Json.Serialization;

    public partial class Osm
    {
        public int Id { get; set; }

        [JsonPropertyName("edit_url")]
        public Uri EditUrl { get; set; }

        [JsonPropertyName("note_url")]
        public Uri NoteUrl { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }
    }
}
