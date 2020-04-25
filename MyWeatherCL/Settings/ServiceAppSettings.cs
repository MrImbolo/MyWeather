using MyWeatherCL.Settings;
using System.Collections.Generic;

namespace MyWeatherService.Settings
{
    public class ServiceAppSettings
    {
        public ServiceAppSettings(Dictionary<string, string> cStrings, Dictionary<string, double> intervals, OpenCageData openCageData, OpenWeatherData openWeatherData, DefaultLocation defaultLocation)
        {
            ConnectionStrings = cStrings;
            Intervals = intervals;
            OpenCageData = openCageData;
            OpenWeatherData = openWeatherData;
            DefaultLocation = defaultLocation;
        }

        public OpenCageData OpenCageData { get; protected set; }
        public OpenWeatherData OpenWeatherData { get; protected set; }
        public DefaultLocation DefaultLocation { get; protected set; }
        public Dictionary<string, double> Intervals { get; protected set; }
        public Dictionary<string, string> ConnectionStrings { get; protected set; }

    }
}
