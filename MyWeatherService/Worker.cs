using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MyWeatherDAL;
using MyWeatherDAL.Models.Weather;
using MyWeatherService.Settings;
using MyWeatherService.Utilities;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MyWeatherDAL.Models.Locations;

namespace MyWeatherService
{
    public partial class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly ServiceAppSettings _appSettings;
        private readonly JsonSerializerOptions _jsonSerializerOptions;
        private readonly MyContext _context;

        public Worker(ILogger<Worker> logger, ServiceAppSettings appSettings, JsonSerializerOptions jsonSerializerOptions, MyContext context)
        {
            _logger = logger;
            _appSettings = appSettings;
            _jsonSerializerOptions = jsonSerializerOptions;
            _context = context;
        }

        protected override async Task ExecuteAsync(CancellationToken ct)
        {
            _logger.LogInformation("Worker started at: {time}", DateTimeOffset.Now);
            if (!await _context.Locations.Where(x => x.Requestable).AnyAsync())
            {
                var httpMessage = new DefaultServiceWeatherRequestBuilder(_appSettings).Build();
                using var ms = new MemoryStream();
                await HttpClientWrapper.RequestStreamAsync(httpMessage, ct, _logger, ms);
                var location = await JsonSerializer.DeserializeAsync<Location>(ms);
                await _context.Locations.AddAsync(location, ct);
                await _context.SaveChangesAsync(ct);
            }

            while (!ct.IsCancellationRequested)
            {
                foreach (var x in await _context.Locations.Where(x => x.Requestable).ToListAsync(ct))
                {
                    var httpMessage = new ServiceWeatherRequestBuilder(_appSettings, x).Build();
                    var result = await ExecuteSending(httpMessage, ct, _logger);
                    result.LocationId = x.Id;
                    x.WeatherSummaries.Add(result);
                }
                await _context.SaveChangesAsync(ct);
                await Task.Delay((int)_appSettings.Intervals["Default"], ct);
            }
        }

        protected async Task<WeatherSummary> ExecuteSending(HttpRequestMessage httpMessage, CancellationToken ct, ILogger logger)
        {
            using var ms = new MemoryStream();
            await HttpClientWrapper.RequestStreamAsync(httpMessage, ct, logger, ms);
            return await JsonSerializer.DeserializeAsync<WeatherSummary>(ms, _jsonSerializerOptions);
        }
    }
}
