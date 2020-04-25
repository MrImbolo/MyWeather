using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyWeatherCL.Settings;
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
        public static ServiceAppSettings ExtractWeatherSettings(this IConfiguration config)
        {
            Dictionary<string, string> cStrings = config.GetSection("ConnectionStrings").Get<Dictionary<string, string>>();
            Dictionary<string, double> intervals = config.GetSection("DefaultIntervals").Get<Dictionary<string, double>>();
            OpenCageData openCageData = config.GetSection("OpenCageData").Get<OpenCageData>();
            OpenWeatherData openWeatherData = config.GetSection("OpenWeatherData").Get<OpenWeatherData>();
            DefaultLocation defaultLocation = config.GetSection("DefaultLocation").Get<DefaultLocation>();

            return new ServiceAppSettings(cStrings, intervals, openCageData, openWeatherData, defaultLocation);
        }

        public static void AddWebAppSettings(this IServiceCollection services, IConfiguration config)
        {
            var cStrings = config.GetSection("ConnectionsStrings").Get<Dictionary<string, string>>();
            var openCageData = config.GetSection("OpenCageData").Get<OpenCageData>();
            var openWeatherData = config.GetSection("OpenWeatherData").Get<OpenWeatherData>();
            services.AddSingleton(new WebAppSettings(cStrings, openCageData, openWeatherData));
        }
    }
}
