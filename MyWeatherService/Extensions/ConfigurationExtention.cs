using Microsoft.Extensions.Configuration;
using MyWeatherService.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Custom extension methods for MyWeatherService
/// </summary>
namespace MyWeatherService.Extensions
{
    /// <summary>
    /// Extension method class for IConfiguration instance
    /// </summary>
    public static class ConfigurationExtention
    {
        /// <summary>
        /// Extension method for extracting defaults and apikeys from iconfiguration instance
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public static AppSettings ExtractWeatherSettings(this IConfiguration config)
        {
            Dictionary<string, string> cStrings = config.GetSection("ConnectionStrings").Get<Dictionary<string, string>>();
            Dictionary<string, double> intervals = config.GetSection("DefaultIntervals").Get<Dictionary<string, double>>();
            OpenCageData openCageData = config.GetSection("OpenCageData").Get<OpenCageData>();
            OpenWeatherData openWeatherData = config.GetSection("OpenWeatherData").Get<OpenWeatherData>();

            return new AppSettings(cStrings, intervals, openCageData, openWeatherData);
        }
    }
}
