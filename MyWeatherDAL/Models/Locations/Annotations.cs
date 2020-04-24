namespace MyWeatherDAL.Models.Locations
{
    using System.Text.Json.Serialization;

    public partial class Annotations
    {
        public int Id { get; set; }

        [JsonPropertyName("DMS")]
        public Dms Dms { get; set; }

        [JsonPropertyName("Mercator")]
        public Mercator Mercator { get; set; }

        [JsonPropertyName("OSM")]
        public Osm Osm { get; set; }

        [JsonPropertyName("callingcode")]
        public long Callingcode { get; set; }

        [JsonPropertyName("currency")]
        public Currency Currency { get; set; }

        [JsonPropertyName("flag")]
        public string Flag { get; set; }

        [JsonPropertyName("geohash")]
        public string Geohash { get; set; }

        [JsonPropertyName("sun")]
        public Sun Sun { get; set; }

        [JsonPropertyName("timezone")]
        public Timezone Timezone { get; set; }

        [JsonPropertyName("what3words")]
        public What3Words What3Words { get; set; }

        [JsonPropertyName("wikidata")]
        public string Wikidata { get; set; }
    }
}
