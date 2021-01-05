namespace MyWeatherDAL.Models.Locations
{
    using System.Text.Json.Serialization;

    public partial class Components
    {
        public int Id { get; set; }

        [JsonPropertyName("ISO_3166-1_alpha-2")]
        public string Iso31661_Alpha2 { get; set; }

        [JsonPropertyName("ISO_3166-1_alpha-3")]
        public string Iso31661_Alpha3 { get; set; }

        [JsonPropertyName("_category")]
        public string Category { get; set; }

        [JsonPropertyName("_type")]
        public string Type { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("continent")]
        public string Continent { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        [JsonPropertyName("county")]
        public string County { get; set; }

        [JsonPropertyName("postcode")]
        public string Postcode { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}
