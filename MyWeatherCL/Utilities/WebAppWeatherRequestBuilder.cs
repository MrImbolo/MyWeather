using MyWeatherCL.Settings;
using MyWeatherCL.Utilities;
using MyWeatherDAL.Models.Locations;
using System.Net.Http;

namespace MyWeatherService.Utilities
{
    public class WebAppWeatherRequestBuilder : RequestBuilderBase
    {
        private readonly WebAppSettings _appSettings;
        private readonly Location _location;

        public WebAppWeatherRequestBuilder(WebAppSettings settings, Location location)
        {
            _appSettings = settings;
            _location = location;
        }
        public override HttpRequestMessage Build()
        {
            string requestUrl = _appSettings.OpenWeatherData.Request
                    .Replace("@Lat", _location.Geometry.Lat.ToString())
                    .Replace("@Lon", _location.Geometry.Lng.ToString())
                    .Replace("@ApiKey", _appSettings.OpenWeatherData.ApiKey.ToString());

            return new HttpRequestMessage(HttpMethod.Get, requestUrl);
        }
    }
}
