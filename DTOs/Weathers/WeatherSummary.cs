using System.Collections.Generic;

namespace DTOs.Weathers
{
    public partial class WeatherSummary
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Timezone { get; set; }
        public Current Current { get; set; }
        public List<Hourly> Hourly { get; set; }
        public List<Daily> Daily { get; set; }
    }
}
