using System.Collections.Generic;

namespace DTO.Weathers
{
    public partial class WeatherSummary
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Timezone { get; set; }
        public Weather Current { get; set; }
        public List<Weather> Hourly { get; set; }
        public List<Weather> Daily { get; set; }
        public int LocationId { get; set; }
    }
}
