using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyWeatherApp.Models;
using MyWeatherDAL;

namespace MyWeatherApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyContext _context;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }


        public async Task<IActionResult> Index(CancellationToken token)
        {
            var location = await _context.Locations.FirstOrDefaultAsync(x => x.Current, token);
            if (location != null)
            {
                ViewBag.Weather = await _context.WeatherSummaries.FirstOrDefaultAsync(x => x.LocationId == location.Id);
                ViewBag.Location = location;
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
