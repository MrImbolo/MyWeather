using MyWeatherCL.Settings;
using MyWeatherCL.Utilities;
using MyWeatherDAL.Models.Locations;
using MyWeatherService.Settings;
using System.Net.Http;

namespace MyWeatherService.Utilities
{
    public class LocationsRequestBuilder : RequestBuilderBase
    {
        private readonly WebAppSettings _appSettings;
        private readonly Location _location;

        public LocationsRequestBuilder(WebAppSettings settings, string searchStr)
        {
            _appSettings = settings;
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
