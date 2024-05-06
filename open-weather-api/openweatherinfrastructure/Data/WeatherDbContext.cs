using Microsoft.EntityFrameworkCore;
using OpenWeather.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeather.Infrastructure.Data
{
    public class WeatherDbContext : DbContext
    {
        public DbContext Instance => this;
        public WeatherDbContext(DbContextOptions<WeatherDbContext> options) : 
            base(options) { }

        public DbSet<WeatherData> WeatherData { get; set; }
        public DbSet<CurrentWeather> CurrentWeather { get; set; }
        public DbSet<MinutelyForecast> MinutelyForecasts { get; set; }
        public DbSet<HourlyForecast> HourlyForecasts { get; set; }
        public DbSet<DailyForecast> DailyForecasts { get; set; }
        public DbSet<Alert> Alerts { get; set; }
        public DbSet<Rain> Rain { get; set; }
        public DbSet<Snow> Snow { get; set; }
        public DbSet<Weather> Weather { get; set; }
        public DbSet<Temperature> Temperatures { get; set; }
        public DbSet<FeelsLike> FeelsLikes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=DabaBaseFile\\open_weather.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
