﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpenWeather.Infrastructure.Data;

#nullable disable

namespace OpenWeather.Infrastructure.Migrations
{
    [DbContext(typeof(WeatherDbContext))]
    partial class WeatherDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("OpenWeather.Domain.Entities.Alert", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("End")
                        .HasColumnType("TEXT");

                    b.Property<string>("Event")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SenderName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Start")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tags")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long?>("WeatherDataId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WeatherDataId");

                    b.ToTable("Alerts");
                });

            modelBuilder.Entity("OpenWeather.Domain.Entities.CurrentWeather", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Clouds")
                        .HasColumnType("INTEGER");

                    b.Property<double>("DewPoint")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Dt")
                        .HasColumnType("TEXT");

                    b.Property<double>("FeelsLike")
                        .HasColumnType("REAL");

                    b.Property<int>("Humidity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Pressure")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Sunrise")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Sunset")
                        .HasColumnType("TEXT");

                    b.Property<double>("Temp")
                        .HasColumnType("REAL");

                    b.Property<double>("Uvi")
                        .HasColumnType("REAL");

                    b.Property<int>("Visibility")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("WeatherDataId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WindDeg")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("WindGust")
                        .HasColumnType("REAL");

                    b.Property<double>("WindSpeed")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("WeatherDataId")
                        .IsUnique();

                    b.ToTable("CurrentWeather");
                });

            modelBuilder.Entity("OpenWeather.Domain.Entities.DailyForecast", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Clouds")
                        .HasColumnType("INTEGER");

                    b.Property<double>("DewPoint")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Dt")
                        .HasColumnType("TEXT");

                    b.Property<int>("Humidity")
                        .HasColumnType("INTEGER");

                    b.Property<double>("MoonPhase")
                        .HasColumnType("REAL");

                    b.Property<DateTime?>("Moonrise")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Moonset")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Pop")
                        .HasColumnType("REAL");

                    b.Property<int>("Pressure")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("Rain")
                        .HasColumnType("REAL");

                    b.Property<double?>("Snow")
                        .HasColumnType("REAL");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Sunrise")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Sunset")
                        .HasColumnType("TEXT");

                    b.Property<double>("Uvi")
                        .HasColumnType("REAL");

                    b.Property<long?>("WeatherDataId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WindDeg")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("WindGust")
                        .HasColumnType("REAL");

                    b.Property<double>("WindSpeed")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("WeatherDataId");

                    b.ToTable("DailyForecasts");
                });

            modelBuilder.Entity("OpenWeather.Domain.Entities.FeelsLike", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("DailyForecastId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Day")
                        .HasColumnType("REAL");

                    b.Property<double>("Eve")
                        .HasColumnType("REAL");

                    b.Property<double>("Morn")
                        .HasColumnType("REAL");

                    b.Property<double>("Night")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("DailyForecastId")
                        .IsUnique();

                    b.ToTable("FeelsLikes");
                });

            modelBuilder.Entity("OpenWeather.Domain.Entities.HourlyForecast", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Clouds")
                        .HasColumnType("INTEGER");

                    b.Property<double>("DewPoint")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Dt")
                        .HasColumnType("TEXT");

                    b.Property<double>("FeelsLike")
                        .HasColumnType("REAL");

                    b.Property<int>("Humidity")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("Pop")
                        .HasColumnType("REAL");

                    b.Property<int>("Pressure")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Temp")
                        .HasColumnType("REAL");

                    b.Property<double>("Uvi")
                        .HasColumnType("REAL");

                    b.Property<int>("Visibility")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("WeatherDataId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WindDeg")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("WindGust")
                        .HasColumnType("REAL");

                    b.Property<double>("WindSpeed")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("WeatherDataId");

                    b.ToTable("HourlyForecasts");
                });

            modelBuilder.Entity("OpenWeather.Domain.Entities.MinutelyForecast", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Dt")
                        .HasColumnType("TEXT");

                    b.Property<int>("Precipitation")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("WeatherDataId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WeatherDataId");

                    b.ToTable("MinutelyForecasts");
                });

            modelBuilder.Entity("OpenWeather.Domain.Entities.Rain", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("CurrentWeatherId")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("HourlyForecastId")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("_1h")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("CurrentWeatherId")
                        .IsUnique();

                    b.HasIndex("HourlyForecastId")
                        .IsUnique();

                    b.ToTable("Rain");
                });

            modelBuilder.Entity("OpenWeather.Domain.Entities.Snow", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("CurrentWeatherId")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("HourlyForecastId")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("_1h")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("CurrentWeatherId")
                        .IsUnique();

                    b.HasIndex("HourlyForecastId")
                        .IsUnique();

                    b.ToTable("Snow");
                });

            modelBuilder.Entity("OpenWeather.Domain.Entities.Temperature", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("DailyForecast")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("DailyForecastId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Day")
                        .HasColumnType("REAL");

                    b.Property<double>("Eve")
                        .HasColumnType("REAL");

                    b.Property<double>("Max")
                        .HasColumnType("REAL");

                    b.Property<double>("Min")
                        .HasColumnType("REAL");

                    b.Property<double>("Morn")
                        .HasColumnType("REAL");

                    b.Property<double>("Night")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("DailyForecast")
                        .IsUnique();

                    b.ToTable("Temperatures");
                });

            modelBuilder.Entity("OpenWeather.Domain.Entities.Weather", b =>
                {
                    b.Property<long>("UniqueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("CurrentWeatherIdWeather")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Main")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long?>("WeatherIdDailyForecast")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("WeatherIdHourlyForecast")
                        .HasColumnType("INTEGER");

                    b.HasKey("UniqueId");

                    b.HasIndex("CurrentWeatherIdWeather");

                    b.HasIndex("WeatherIdDailyForecast");

                    b.HasIndex("WeatherIdHourlyForecast");

                    b.ToTable("Weather");
                });

            modelBuilder.Entity("OpenWeather.Domain.Entities.WeatherData", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Lat")
                        .HasColumnType("REAL");

                    b.Property<double>("Lon")
                        .HasColumnType("REAL");

                    b.Property<string>("Timezone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TimezoneOffset")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("WeatherData");
                });

            modelBuilder.Entity("OpenWeather.Domain.Entities.Alert", b =>
                {
                    b.HasOne("OpenWeather.Domain.Entities.WeatherData", "WeatherDataIdNavigation")
                        .WithMany("Alerts")
                        .HasForeignKey("WeatherDataId");

                    b.Navigation("WeatherDataIdNavigation");
                });

            modelBuilder.Entity("OpenWeather.Domain.Entities.CurrentWeather", b =>
                {
                    b.HasOne("OpenWeather.Domain.Entities.WeatherData", "WeatherDataIdNavigation")
                        .WithOne("Current")
                        .HasForeignKey("OpenWeather.Domain.Entities.CurrentWeather", "WeatherDataId");

                    b.Navigation("WeatherDataIdNavigation");
                });

            modelBuilder.Entity("OpenWeather.Domain.Entities.DailyForecast", b =>
                {
                    b.HasOne("OpenWeather.Domain.Entities.WeatherData", "WeatherDataIdNavigation")
                        .WithMany("Daily")
                        .HasForeignKey("WeatherDataId");

                    b.Navigation("WeatherDataIdNavigation");
                });

            modelBuilder.Entity("OpenWeather.Domain.Entities.FeelsLike", b =>
                {
                    b.HasOne("OpenWeather.Domain.Entities.DailyForecast", "DailyForecastIdNavigation")
                        .WithOne("FeelsLike")
                        .HasForeignKey("OpenWeather.Domain.Entities.FeelsLike", "DailyForecastId");

                    b.Navigation("DailyForecastIdNavigation");
                });

            modelBuilder.Entity("OpenWeather.Domain.Entities.HourlyForecast", b =>
                {
                    b.HasOne("OpenWeather.Domain.Entities.WeatherData", "WeatherDataIdNavigation")
                        .WithMany("Hourly")
                        .HasForeignKey("WeatherDataId");

                    b.Navigation("WeatherDataIdNavigation");
                });

            modelBuilder.Entity("OpenWeather.Domain.Entities.MinutelyForecast", b =>
                {
                    b.HasOne("OpenWeather.Domain.Entities.WeatherData", "WeatherDataIdNavigation")
                        .WithMany("Minutely")
                        .HasForeignKey("WeatherDataId");

                    b.Navigation("WeatherDataIdNavigation");
                });

            modelBuilder.Entity("OpenWeather.Domain.Entities.Rain", b =>
                {
                    b.HasOne("OpenWeather.Domain.Entities.CurrentWeather", "CurrentWeatherIdNavigation")
                        .WithOne("Rain")
                        .HasForeignKey("OpenWeather.Domain.Entities.Rain", "CurrentWeatherId");

                    b.HasOne("OpenWeather.Domain.Entities.HourlyForecast", "HourlyForecastIdNavigation")
                        .WithOne("Rain")
                        .HasForeignKey("OpenWeather.Domain.Entities.Rain", "HourlyForecastId");

                    b.Navigation("CurrentWeatherIdNavigation");

                    b.Navigation("HourlyForecastIdNavigation");
                });

            modelBuilder.Entity("OpenWeather.Domain.Entities.Snow", b =>
                {
                    b.HasOne("OpenWeather.Domain.Entities.CurrentWeather", "CurrentWeatherIdNavigation")
                        .WithOne("Snow")
                        .HasForeignKey("OpenWeather.Domain.Entities.Snow", "CurrentWeatherId");

                    b.HasOne("OpenWeather.Domain.Entities.HourlyForecast", "HourlyForecastIdNavigation")
                        .WithOne("Snow")
                        .HasForeignKey("OpenWeather.Domain.Entities.Snow", "HourlyForecastId");

                    b.Navigation("CurrentWeatherIdNavigation");

                    b.Navigation("HourlyForecastIdNavigation");
                });

            modelBuilder.Entity("OpenWeather.Domain.Entities.Temperature", b =>
                {
                    b.HasOne("OpenWeather.Domain.Entities.DailyForecast", "DailyForecastIdNavigation")
                        .WithOne("Temp")
                        .HasForeignKey("OpenWeather.Domain.Entities.Temperature", "DailyForecast");

                    b.Navigation("DailyForecastIdNavigation");
                });

            modelBuilder.Entity("OpenWeather.Domain.Entities.Weather", b =>
                {
                    b.HasOne("OpenWeather.Domain.Entities.CurrentWeather", "CurrentWeatherIdWeatherNavigation")
                        .WithMany("Weather")
                        .HasForeignKey("CurrentWeatherIdWeather");

                    b.HasOne("OpenWeather.Domain.Entities.DailyForecast", "WeatherIdDailyForecastNavigation")
                        .WithMany("Weather")
                        .HasForeignKey("WeatherIdDailyForecast");

                    b.HasOne("OpenWeather.Domain.Entities.HourlyForecast", "WeatherIdHourlyForecastNavigation")
                        .WithMany("Weather")
                        .HasForeignKey("WeatherIdHourlyForecast");

                    b.Navigation("CurrentWeatherIdWeatherNavigation");

                    b.Navigation("WeatherIdDailyForecastNavigation");

                    b.Navigation("WeatherIdHourlyForecastNavigation");
                });

            modelBuilder.Entity("OpenWeather.Domain.Entities.CurrentWeather", b =>
                {
                    b.Navigation("Rain")
                        .IsRequired();

                    b.Navigation("Snow")
                        .IsRequired();

                    b.Navigation("Weather");
                });

            modelBuilder.Entity("OpenWeather.Domain.Entities.DailyForecast", b =>
                {
                    b.Navigation("FeelsLike")
                        .IsRequired();

                    b.Navigation("Temp")
                        .IsRequired();

                    b.Navigation("Weather");
                });

            modelBuilder.Entity("OpenWeather.Domain.Entities.HourlyForecast", b =>
                {
                    b.Navigation("Rain")
                        .IsRequired();

                    b.Navigation("Snow")
                        .IsRequired();

                    b.Navigation("Weather");
                });

            modelBuilder.Entity("OpenWeather.Domain.Entities.WeatherData", b =>
                {
                    b.Navigation("Alerts");

                    b.Navigation("Current")
                        .IsRequired();

                    b.Navigation("Daily");

                    b.Navigation("Hourly");

                    b.Navigation("Minutely");
                });
#pragma warning restore 612, 618
        }
    }
}
