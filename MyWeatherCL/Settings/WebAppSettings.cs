using System.Collections.Generic;

namespace MyWeatherCL.Settings
{
    public class WebAppSettings
    {
        public WebAppSettings(Dictionary<string, string> cStrings, OpenCageData openCageData, OpenWeatherData openWeatherData)
        {
            ConnectionStrings = cStrings;
            OpenCageData = openCageData;
            OpenWeatherData = openWeatherData;
        }

        public OpenCageData OpenCageData { get; protected set; }
        public OpenWeatherData OpenWeatherData { get; protected set; }
        public Dictionary<string, string> ConnectionStrings { get; protected set; }

    }
}
