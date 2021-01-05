using Microsoft.AspNetCore.Mvc;
using MyWeatherCL.Utilities;
using MyWeatherDAL.JsonConverters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyWeatherApp.Extensions
{
    public static class JsonOptionsExtensions
    {
        public static void SetCustomJsonOptions(this JsonOptions options)
        {
            var customOptions = JsonOptionsGlobal.Custom;
            options.JsonSerializerOptions.PropertyNameCaseInsensitive = customOptions.PropertyNameCaseInsensitive;
            options.JsonSerializerOptions.DictionaryKeyPolicy = customOptions.DictionaryKeyPolicy;
            options.JsonSerializerOptions.PropertyNamingPolicy = customOptions.PropertyNamingPolicy;
            options.JsonSerializerOptions.Converters.Add(new DoubleToStringConverter());
            options.JsonSerializerOptions.Converters.Add(new UnixDateTimeJsonConverter());
        }
    }
}
