using Microsoft.EntityFrameworkCore;
using MyWeatherDAL.Models.Locations;
using MyWeatherDAL.Models.Weather;

namespace MyWeatherDAL
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Weather> Weathers { get; set; }
        public DbSet<FeelsLike> FeelsLikes { get; set; }
        public DbSet<Temp> Temps { get; set; }
        public DbSet<WeatherDescription> WeatherDescriptions { get; set; }
        public DbSet<WeatherSummary> WeatherSummaries { get; set; }
        public DbSet<Annotations> Annotations{ get; set; }
        public DbSet<Components> Components { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Dms> Dms { get; set; }
        public DbSet<Geometry> Geometries { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Mercator> Mercators { get; set; }
        public DbSet<Osm> Osms { get; set; }
        public DbSet<Rise> Rises { get; set; }
        public DbSet<Sun> Suns { get; set; }
        public DbSet<Timezone> Timezones { get; set; }
        public DbSet<What3Words> What3Words { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().HasIndex(u => u.Id).IsUnique();
            modelBuilder.Entity<Weather>().HasIndex(u => u.Id).IsUnique();
            modelBuilder.Entity<FeelsLike>().HasIndex(u => u.Id).IsUnique();
            modelBuilder.Entity<Temp>().HasIndex(u => u.Id).IsUnique();
            modelBuilder.Entity<WeatherDescription>().HasIndex(u => u.Id).IsUnique();
            modelBuilder.Entity<WeatherSummary>().HasIndex(u => u.Id).IsUnique();
            modelBuilder.Entity<Annotations>().HasIndex(u => u.Id).IsUnique();
            modelBuilder.Entity<Components>().HasIndex(u => u.Id).IsUnique();
            modelBuilder.Entity<Currency>().HasIndex(u => u.Id).IsUnique();
            modelBuilder.Entity<Dms>().HasIndex(u => u.Id).IsUnique();
            modelBuilder.Entity<Geometry>().HasIndex(u => u.Id).IsUnique();
            modelBuilder.Entity<Mercator>().HasIndex(u => u.Id).IsUnique();
            modelBuilder.Entity<Osm>().HasIndex(u => u.Id).IsUnique();
            modelBuilder.Entity<Rise>().HasIndex(u => u.Id).IsUnique();
            modelBuilder.Entity<Sun>().HasIndex(u => u.Id).IsUnique();
            modelBuilder.Entity<Timezone>().HasIndex(u => u.Id).IsUnique();
            modelBuilder.Entity<What3Words>().HasIndex(u => u.Id).IsUnique();
        }
    }
}