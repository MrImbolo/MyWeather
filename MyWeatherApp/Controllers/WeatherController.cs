using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyWeatherCL.Settings;
using MyWeatherDAL;
using MyWeatherDAL.Models.Weather;
using MyWeatherService.Utilities;
using System;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace MyWeatherApp.Controllers
{
    public class WeatherController : Controller
    {
        private readonly MyContext _context;
        private readonly WebAppSettings _settings;
        private readonly JsonSerializerOptions _jsonOptions;
        private readonly ILogger<WeatherController> _logger;

        public WeatherController(MyContext context, WebAppSettings settings, JsonSerializerOptions jsonOptions, ILogger<WeatherController> logger)
        {
            _context = context;
            _settings = settings;
            _jsonOptions = jsonOptions;
            _logger = logger;
        }
        public async Task<IActionResult> Get(CancellationToken ct)
        {
            if (Request.Cookies.TryGetValue("LocationId", out string value))
                if (int.TryParse(value, out int locationId))
                {
                    if (locationId != 0)
                    {
                        try
                        {
                            var location = await _context.Locations
                                .Where(x => x.Id == locationId)
                                .Include("Annotations")
                                .Include("Components")
                                .Include("Geometry")
                                .Include(l => l.WeatherSummaries)
                                    .ThenInclude(ws => ws.Current)
                                .FirstOrDefaultAsync(ct)
                                .ConfigureAwait(false);

                            if (location != null)
                            {
                                ViewBag.Location = location;

                                //var msg = new WebAppWeatherRequestBuilder(_settings, location).Build();
                                //var jsonString = await HttpClientWrapper.RequestStringAsync(msg, ct, _logger);
                        
                                //var weather = JsonSerializer.Deserialize<WeatherSummary>(jsonString, _jsonOptions);
                        
                                //ViewBag.WeatherSummary = weather;

                                return PartialView("_WeatherInfoPartial");
                            }
                        }
                        catch (InvalidOperationException ioe)
                        {
                            _logger.LogError($"Exception catched at {nameof(WeatherController)}, ef data fetching: {ioe.Message}", ioe);
                        }
                    }

                    Response.Cookies.Delete("LocationId");
                    return PartialView("_LocationFindPartial", new { Error = new { StatusCode = 404, ErrorMessage = "No such location found"  } });
                }

            Response.Cookies.Delete("LocationId");
            return PartialView("_LocationFindPartial");
        }
    }
}