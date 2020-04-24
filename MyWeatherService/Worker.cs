using DTO.Weathers;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MyWeatherCL.MyWeatherServicesDuplicates;
using MyWeatherService.Utilities;
using MyWeatherDAL;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace MyWeatherService
{
    public partial class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly AppSettings _appSettings;
        private readonly JsonSerializerOptions _jsonSerializerOptions;
        private readonly MyContext _context;
        private readonly RequestableLocationLoader _requestableLocationLoader;

        public Worker(ILogger<Worker> logger, AppSettings appSettings, JsonSerializerOptions jsonSerializerOptions, MyContext context)
        {
            _logger = logger;
            _appSettings = appSettings;
            _jsonSerializerOptions = jsonSerializerOptions;
            _context = context;
            _requestableLocationLoader = new RequestableLocationLoader(_context);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Worker started at: {time}", DateTimeOffset.Now);
            while (!stoppingToken.IsCancellationRequested)
            {

                var locations = _requestableLocationLoader.Load();
                if (!locations.Any())
                {
                    var httpMessage = new DefaultServiceWeatherRequestBuilder(_appSettings).Build();

                    
                }
                else
                {
                    locations.AsParallel().ForAll(async x =>
                    {
                        var httpMessage = new ServiceWeatherRequestBuilder(_appSettings, x).Build();
                        var result = await ExecuteSending(httpMessage, stoppingToken, _logger);
                        result.LocationId = x.Id;
                        await HandleRequestedData(result);
                    });
                }
               
                // Match the new data with existing and override parts not confirmed by more fresh data
                

                await Task.Delay((int)_appSettings.Intervals["Default"], stoppingToken);
            }
        }
        protected async Task HandleRequestedData(WeatherSummary summary)
        {
            // TODO: if weather for such location exists
            
        }
        protected async Task<WeatherSummary> ExecuteSending(HttpRequestMessage httpMessage, CancellationToken token, ILogger logger)
        {
            using (var ms = new MemoryStream())
            {
                await HttpClientWrapper.RequestStream(httpMessage, token, logger, ms);
                return await JsonSerializer.DeserializeAsync<WeatherSummary>(ms, _jsonSerializerOptions);
            }
        }
    }
}
