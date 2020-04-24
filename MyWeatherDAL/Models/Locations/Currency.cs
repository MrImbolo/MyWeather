namespace MyWeatherDAL.Models.Locations
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class Currency
    {
        public int Id { get; set; }

        [JsonPropertyName("alternate_symbols")]
        public List<string> AlternateSymbols { get; set; }

        [JsonPropertyName("decimal_mark")]
        public string DecimalMark { get; set; }

        [JsonPropertyName("html_entity")]
        public string HtmlEntity { get; set; }

        [JsonPropertyName("iso_code")]
        public string IsoCode { get; set; }

        [JsonPropertyName("iso_numeric")]
        public long IsoNumeric { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("smallest_denomination")]
        public long SmallestDenomination { get; set; }

        [JsonPropertyName("subunit")]
        public string Subunit { get; set; }

        [JsonPropertyName("subunit_to_unit")]
        public long SubunitToUnit { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("symbol_first")]
        public long SymbolFirst { get; set; }

        [JsonPropertyName("thousands_separator")]
        public string ThousandsSeparator { get; set; }
    }
}
