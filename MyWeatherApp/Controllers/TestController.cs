using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWeatherDAL;
using MyWeatherDAL.DTOs.Tests;
using MyWeatherDAL.Models.Locations;

namespace MyWeatherApp.Controllers
{
    public class TestController : Controller
    {
        private readonly ILogger<TestController> _logger;
        private readonly MyContext _context;
        private readonly JsonSerializerOptions _jsonOptions;

        public TestController(ILogger<TestController> logger, MyContext context, JsonSerializerOptions jsonSerializerOptions)
        {
            _logger = logger;
            _context = context;
            _jsonOptions = jsonSerializerOptions;
        }
        public IActionResult Index()
        {
            ViewBag.Types = AppDomain.CurrentDomain.GetAssemblies()
                          .SelectMany(t => t.GetTypes())
                          .Where(t => t.IsClass && ((t.Namespace?.Contains("MyWeatherDAL.Models") ?? false) || (t.Namespace?.Contains("MyWeatherDAL.DTO") ?? false)))
                          .Select(x => x.Name).ToList();
            return View();
        }
        [HttpPost]
        public IActionResult LocationSerialization([FromBody]DeserializationTestDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Json))
            {
                dto.Json = "{\"annotations\":{\"DMS\":{\"lat\":\"45° 2' 6.92376'' N\",\"lng\":\"38° 58' 35.33304'' E\"},\"MGRS\":\"37TDK9814786867\",\"Maidenhead\":\"KN95la78el\",\"Mercator\":{\"x\":4338842.062,\"y\":5596829.422},\"OSM\":{\"edit_url\":\"https://www.openstreetmap.org/edit?relation=7373058#map=17/45.03526/38.97648\",\"note_url\":\"https://www.openstreetmap.org/note/new#map=17/45.03526/38.97648&layers=N\",\"url\":\"https://www.openstreetmap.org/?mlat=45.03526&mlon=38.97648#map=17/45.03526/38.97648\"},\"UN_M49\":{\"regions\":{\"EASTERN_EUROPE\":\"151\",\"EUROPE\":\"150\",\"RU\":\"643\",\"WORLD\":\"001\"},\"statistical_groupings\":[\"MEDC\"]},\"callingcode\":7,\"currency\":{\"alternate_symbols\":[\"руб.\",\"р.\"],\"decimal_mark\":\",\",\"html_entity\":\"&#x20BD;\",\"iso_code\":\"RUB\",\"iso_numeric\":\"643\",\"name\":\"Russian Ruble\",\"smallest_denomination\":1,\"subunit\":\"Kopeck\",\"subunit_to_unit\":100,\"symbol\":\"₽\",\"symbol_first\":0,\"thousands_separator\":\".\"},\"flag\":\"🇷🇺\",\"geohash\":\"ub58nymv3u6czccyx3n1\",\"qibla\":178.03,\"roadinfo\":{\"drive_on\":\"right\",\"speed_in\":\"km/h\"},\"sun\":{\"rise\":{\"apparent\":1587781440,\"astronomical\":1587774660,\"civil\":1587779520,\"nautical\":1587777180},\"set\":{\"apparent\":1587831660,\"astronomical\":1587838500,\"civil\":1587833580,\"nautical\":1587835920}},\"timezone\":{\"name\":\"Europe/Moscow\",\"now_in_dst\":0,\"offset_sec\":10800,\"offset_string\":\"+0300\",\"short_name\":\"MSK\"},\"what3words\":{\"words\":\"bleak.hatter.waters\"},\"wikidata\":\"Q3646\"},\"bounds\":{\"northeast\":{\"lat\":45.1516172,\"lng\":39.1460448},\"southwest\":{\"lat\":44.9679583,\"lng\":38.8458879}},\"components\":{\"ISO_3166-1_alpha-2\":\"RU\",\"ISO_3166-1_alpha-3\":\"RUS\",\"_category\":\"place\",\"_type\":\"city\",\"city\":\"Краснодар\",\"continent\":\"Europe\",\"country\":\"Россия\",\"country_code\":\"ru\",\"county\":\"городской округ Краснодар\",\"postcode\":\"350000\",\"state\":\"Краснодарский край\"},\"confidence\":4,\"formatted\":\"Краснодар, городской округ Краснодар, Россия\",\"geometry\":{\"lat\":45.0352566,\"lng\":38.9764814},\"id\":0}";
                dto.Type = "Location";   
            }
            Type type = typeof(MyWeatherDAL.Models.Weather.FeelsLike).Assembly.GetTypes().FirstOrDefault(x => x.Name == dto.Type);

            var method = typeof(JsonSerializer).GetMethods().Where(x => x.Name == "Deserialize" && x.IsGenericMethod).FirstOrDefault();
            var genMethod = method.MakeGenericMethod(type);

            try
            {
                var generatedModel = genMethod.Invoke(null, new object[] { dto.Json, _jsonOptions });
                return Content(@"{ ""success"" : true }", "application/json");
            }
            catch(Exception ex)
            {
                return Content($@"{{ ""success"" : false, ""error"": ""{ex.Message}"" }}", "application/json");
            }
        }
    }
}