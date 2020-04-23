using System.Net.Http;
using MyWeatherService.Settings;

namespace MyWeatherService.Utilities
{
    public class ServiceWeatherRequestBuilder : RequestBuilderBase
    {
        private readonly AppSettings _appSettings;
        public ServiceWeatherRequestBuilder(AppSettings settings)
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
