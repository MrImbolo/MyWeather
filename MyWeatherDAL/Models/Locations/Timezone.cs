namespace MyWeatherDAL.Models.Locations
{
    using System.Text.Json.Serialization;

    public partial class Timezone
    {
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("now_in_dst")]
        public long NowInDst { get; set; }

        [JsonPropertyName("offset_sec")]
        public long OffsetSec { get; set; }

        [JsonPropertyName("offset_string")]
        public string OffsetString { get; set; }

        [JsonPropertyName("short_name")]
        public string ShortName { get; set; }
    }
}
