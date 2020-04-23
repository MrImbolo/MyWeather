using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
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

        public Worker(ILogger<Worker> logger, AppSettings appSettings)
        {
            _logger = logger;
            _appSettings = appSettings;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Worker started at: {time}", DateTimeOffset.Now);
            while (!stoppingToken.IsCancellationRequested)
            {
                
                var result = await HttpClientWrapper.Request(new ServiceWeatherRequestBuilder(_appSettings).Build(), stoppingToken, _logger);



                await Task.Delay((int)_appSettings.Intervals["Default"], stoppingToken);
            }
        }

    }
}
