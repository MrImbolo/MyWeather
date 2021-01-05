using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace MyWeatherCL.Utilities
{
    public class JsonOptionsGlobal
    {
        public static JsonSerializerOptions Custom 
            => new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };   
    }
}
