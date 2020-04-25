using MyWeatherCL.Utilities;
using MyWeatherService.Settings;
using System.Net.Http;

namespace MyWeatherService.Utilities
{
    public class DefaultServiceWeatherRequestBuilder : RequestBuilderBase
    {
        private readonly ServiceAppSettings _appSettings;
        public DefaultServiceWeatherRequestBuilder(ServiceAppSettings settings)
        {
            _appSettings = settings;
        }
        public override HttpRequestMessage Build()
        {
            string requestUrl = _appSettings.OpenWeatherData.Request
                    .Replace("@Lat", _appSettings.DefaultLocation.Lat.ToString())
                    .Replace("@Lon", _appSettings.DefaultLocation.Lon.ToString())
                    .Replace("@ApiKey", _appSettings.OpenWeatherData.ApiKey.ToString());

            return new HttpRequestMessage(HttpMethod.Get, requestUrl);
        }
    }
}
