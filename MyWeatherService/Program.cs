using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyWeatherDAL;
using MyWeatherService.Extensions;
using MyWeatherService.Settings;

namespace MyWeatherService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    ServiceAppSettings appSettings = hostContext.Configuration.ExtractWeatherSettings();

                    JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
                    {
                        WriteIndented = true,
                        PropertyNameCaseInsensitive = true,
                        DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    };

                    services.AddDbContext<MyContext>(options =>
                    {
                        options.UseNpgsql(appSettings.ConnectionStrings["Default"]/*, npgOptions => npgOptions.MigrationsAssembly("MyWeatherService")*/);
                    }, ServiceLifetime.Singleton);

                    services.AddSingleton(appSettings);
                    services.AddSingleton(jsonSerializerOptions);
                    services.AddHostedService<Worker>();
                });
    }
}
