using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyWeatherCL.Settings;
using MyWeatherDAL;
using MyWeatherDAL.Models.Locations;
using MyWeatherService.Utilities;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace MyWeatherApp.Controllers
{
    public class LocationsController : Controller
    {
        private readonly MyContext _context;
        private readonly WebAppSettings _settings;
        private readonly ILogger<LocationsController> _logger;

        public LocationsController(MyContext context, WebAppSettings settings, ILogger<LocationsController> logger)
        {
            _context = context;
            _settings = settings;
            _logger = logger;
        }

        //[HttpGet]
        //public IActionResult OpenCageApiKey() => Ok(_settings.OpenCageData.ApiKey);

        public async Task<IActionResult> Change(CancellationToken ct)
        {
            if (Request.Cookies.TryGetValue("LocationId", out string value))
                if (int.TryParse(value, out int locationId))
                {
                    (await _context.Locations.Where(x => x.Id == locationId).ToListAsync(ct)).ForEach(x => x.Requestable = false);
                    await _context.SaveChangesAsync(ct);
                    Response.Cookies.Delete("LocationId");
                }
            return PartialView("_LocationFindPartial");
        }
        public async Task<IActionResult> Get([FromQuery]string searchStr, CancellationToken token)
        {
            // var locations = await _context.Locations.Include("Geometry").Where(x => x.Formatted.ToUpperInvariant().Contains(searchStr.ToUpperInvariant())).ToListAsync(token);

            var httpMessage = new LocationsRequestBuilder(_settings, searchStr).Build();
            var result = await HttpClientWrapper.RequestStringAsync(httpMessage, token, _logger);

            if (string.IsNullOrWhiteSpace(result))
                result = "{}";

            return Content(result, "application/json");
        }

        [HttpPost]
        public async Task<IActionResult> Set([FromBody]Location location, CancellationToken ct)
        {
            if (location != null)
            {
                var locationExist = await _context.Locations.FirstOrDefaultAsync(x => x.Formatted == location.Formatted);
                
                if (locationExist == null)
                {
                    await _context.Locations.AddAsync(location, ct);
                    await _context.SaveChangesAsync(ct);
                    locationExist = location;
                }

                ViewBag.Location = locationExist;

                Response.Cookies.Append("LocationId", locationExist.Id.ToString());


                return RedirectToAction("Get", "Weather");
            }

            return BadRequest();
        }
    }
}