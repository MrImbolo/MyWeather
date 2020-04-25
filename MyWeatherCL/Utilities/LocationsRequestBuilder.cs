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
        private readonly string _searchStr;
        public LocationsRequestBuilder(WebAppSettings settings, string searchStr)
        {
            _appSettings = settings;
            _searchStr = searchStr;
        }
        public override HttpRequestMessage Build()
        {
            string requestUrl = _appSettings.OpenCageData.Request
                    .Replace("@Location", _searchStr)
                    .Replace("@ApiKey", _appSettings.OpenCageData.ApiKey.ToString());

            return new HttpRequestMessage(HttpMethod.Get, requestUrl);
        }
    }
}
