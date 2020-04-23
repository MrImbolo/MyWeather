using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading;
using System.Threading.Tasks;
using DTOs.Weathers;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MyWeatherService.Settings;
using MyWeatherService.Utilities;

namespace MyWeatherService
{
    public partial class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly AppSettings _appSettings;
        private readonly JsonSerializerOptions _jsonSerializerOptions;


        public Worker(ILogger<Worker> logger, AppSettings appSettings, JsonSerializerOptions jsonSerializerOptions)
        {
            _logger = logger;
            _appSettings = appSettings;
            _jsonSerializerOptions = jsonSerializerOptions;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Worker started at: {time}", DateTimeOffset.Now);
            while (!stoppingToken.IsCancellationRequested)
            {
                
                var httpMessage = new ServiceWeatherRequestBuilder(_appSettings).Build();

                var jsonString = await HttpClientWrapper.RequestString(httpMessage, stoppingToken, _logger);

                var result = JsonSerializer.Deserialize<WeatherSummary>(jsonString, _jsonSerializerOptions);
               
                // TODO: add a logic to storing necessary data in the db

                await Task.Delay((int)_appSettings.Intervals["Default"], stoppingToken);
            }
        }

    }
}
