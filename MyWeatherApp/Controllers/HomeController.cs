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
using MyWeatherDAL.Models.Locations;

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


        public IActionResult Index(CancellationToken token)
        {
            return View();
        }

        public async Task<IActionResult> Weather([FromBody]Location location, CancellationToken ct)
        {
            await Task.Delay(5000);
            if (location != null)
            {
                var locationExist = await _context.Locations.FirstOrDefaultAsync(x => x.Formatted == location.Formatted) ?? (await _context.Locations.AddAsync(location)).Entity;
                ViewBag.Location = locationExist;
                
                // TODO: rename _WeatherPartial to something like _WeatherFramePartial
                // TODO: divide logic between location search partial and weather partial and load them separately from different controllers
                // TODO: FINALLY ADD SOME LOCATIONS AND WEATHER 
                
                return PartialView("_WeatherPartial");
            }

            return BadRequest();
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
