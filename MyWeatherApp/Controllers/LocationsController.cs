using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyWeatherCL.Settings;
using MyWeatherDAL;
using MyWeatherService.Utilities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MyWeatherApp.Controllers
{
    public class LocationsController : Controller
    {
        private readonly MyContext _context;
        private readonly WebAppSettings _settings;
        private readonly ILogger _logger;

        public LocationsController(MyContext context, WebAppSettings settings, ILogger logger)
        {
            _context = context;
            _settings = settings;
            _logger = logger;
        }
        public async Task<IActionResult> Get([FromQuery]string searchStr, CancellationToken token)
        {
            var locations = await _context.Locations.Include("Geometry").Where(x => x.Formatted.ToUpperInvariant().Contains(searchStr.ToUpperInvariant())).ToListAsync(token);

            var httpMessage = new LocationsRequestBuilder(_settings, searchStr).Build();
            var result = await HttpClientWrapper.RequestString(httpMessage, token, _logger);

            return Ok(result);
        }
    }
}