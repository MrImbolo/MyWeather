using MyWeatherDAL;
using MyWeatherDAL.Models.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeatherService.Utilities
{
    public class RequestableLocationLoader
    {
        private readonly MyContext _context;
        public RequestableLocationLoader(MyContext context)
        {
            _context = context;
        }

        public List<Location> Load() => _context.Locations.Where(x => x.Requestable).ToList();
    }
}
