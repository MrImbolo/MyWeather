using System.Net.Http;

namespace MyWeatherCL.Utilities
{
    public abstract class RequestBuilderBase
    {
        public abstract HttpRequestMessage Build();
    }
}
