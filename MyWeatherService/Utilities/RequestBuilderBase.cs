﻿using System.Net.Http;

namespace MyWeatherService.Utilities
{
    public abstract class RequestBuilderBase
    {
        public abstract HttpRequestMessage Build();
    }
}
