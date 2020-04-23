using DTOs.Weathers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
namespace MyWeatherDAL
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }

        DbSet<Current> Currents { get; set; }
        DbSet<Daily> Dailies { get; set; }
        DbSet<FeelsLike> FeelsLikes{ get; set; }
        DbSet<Hourly> Hourlies{ get; set; }
        DbSet<Rain> Rains{ get; set; }
        DbSet<Temp> Temps{ get; set; }
        DbSet<Weather> Weathers { get; set; }
        DbSet<WeatherSummary> WeatherSummaries { get; set; }
    }
}