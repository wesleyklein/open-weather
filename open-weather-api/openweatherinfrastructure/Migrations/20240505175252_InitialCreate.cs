using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpenWeather.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeatherData",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Lat = table.Column<double>(type: "REAL", nullable: false),
                    Lon = table.Column<double>(type: "REAL", nullable: false),
                    Timezone = table.Column<string>(type: "TEXT", nullable: false),
                    TimezoneOffset = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Alerts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SenderName = table.Column<string>(type: "TEXT", nullable: false),
                    Event = table.Column<string>(type: "TEXT", nullable: false),
                    Start = table.Column<DateTime>(type: "TEXT", nullable: false),
                    End = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Tags = table.Column<string>(type: "TEXT", nullable: false),
                    WeatherDataId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alerts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alerts_WeatherData_WeatherDataId",
                        column: x => x.WeatherDataId,
                        principalTable: "WeatherData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CurrentWeather",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Dt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Sunrise = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Sunset = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Temp = table.Column<double>(type: "REAL", nullable: false),
                    FeelsLike = table.Column<double>(type: "REAL", nullable: false),
                    Pressure = table.Column<int>(type: "INTEGER", nullable: false),
                    Humidity = table.Column<int>(type: "INTEGER", nullable: false),
                    DewPoint = table.Column<double>(type: "REAL", nullable: false),
                    Uvi = table.Column<double>(type: "REAL", nullable: false),
                    Clouds = table.Column<int>(type: "INTEGER", nullable: false),
                    Visibility = table.Column<int>(type: "INTEGER", nullable: false),
                    WindSpeed = table.Column<double>(type: "REAL", nullable: false),
                    WindDeg = table.Column<int>(type: "INTEGER", nullable: false),
                    WindGust = table.Column<double>(type: "REAL", nullable: true),
                    WeatherDataId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentWeather", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurrentWeather_WeatherData_WeatherDataId",
                        column: x => x.WeatherDataId,
                        principalTable: "WeatherData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DailyForecasts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Dt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Sunrise = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Sunset = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Moonrise = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Moonset = table.Column<DateTime>(type: "TEXT", nullable: true),
                    MoonPhase = table.Column<double>(type: "REAL", nullable: false),
                    Summary = table.Column<string>(type: "TEXT", nullable: false),
                    Pressure = table.Column<int>(type: "INTEGER", nullable: false),
                    Humidity = table.Column<int>(type: "INTEGER", nullable: false),
                    DewPoint = table.Column<double>(type: "REAL", nullable: false),
                    WindSpeed = table.Column<double>(type: "REAL", nullable: false),
                    WindDeg = table.Column<int>(type: "INTEGER", nullable: false),
                    WindGust = table.Column<double>(type: "REAL", nullable: true),
                    Clouds = table.Column<int>(type: "INTEGER", nullable: false),
                    Pop = table.Column<double>(type: "REAL", nullable: true),
                    Rain = table.Column<double>(type: "REAL", nullable: true),
                    Snow = table.Column<double>(type: "REAL", nullable: true),
                    Uvi = table.Column<double>(type: "REAL", nullable: false),
                    WeatherDataId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyForecasts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DailyForecasts_WeatherData_WeatherDataId",
                        column: x => x.WeatherDataId,
                        principalTable: "WeatherData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HourlyForecasts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Dt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Temp = table.Column<double>(type: "REAL", nullable: false),
                    FeelsLike = table.Column<double>(type: "REAL", nullable: false),
                    Pressure = table.Column<int>(type: "INTEGER", nullable: false),
                    Humidity = table.Column<int>(type: "INTEGER", nullable: false),
                    DewPoint = table.Column<double>(type: "REAL", nullable: false),
                    Uvi = table.Column<double>(type: "REAL", nullable: false),
                    Clouds = table.Column<int>(type: "INTEGER", nullable: false),
                    Visibility = table.Column<int>(type: "INTEGER", nullable: false),
                    WindSpeed = table.Column<double>(type: "REAL", nullable: false),
                    WindDeg = table.Column<int>(type: "INTEGER", nullable: false),
                    WindGust = table.Column<double>(type: "REAL", nullable: true),
                    Pop = table.Column<double>(type: "REAL", nullable: true),
                    WeatherDataId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HourlyForecasts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HourlyForecasts_WeatherData_WeatherDataId",
                        column: x => x.WeatherDataId,
                        principalTable: "WeatherData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MinutelyForecasts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Dt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Precipitation = table.Column<int>(type: "INTEGER", nullable: false),
                    WeatherDataId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MinutelyForecasts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MinutelyForecasts_WeatherData_WeatherDataId",
                        column: x => x.WeatherDataId,
                        principalTable: "WeatherData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FeelsLikes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Day = table.Column<double>(type: "REAL", nullable: false),
                    Night = table.Column<double>(type: "REAL", nullable: false),
                    Eve = table.Column<double>(type: "REAL", nullable: false),
                    Morn = table.Column<double>(type: "REAL", nullable: false),
                    DailyForecastId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeelsLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeelsLikes_DailyForecasts_DailyForecastId",
                        column: x => x.DailyForecastId,
                        principalTable: "DailyForecasts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Temperatures",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Day = table.Column<double>(type: "REAL", nullable: false),
                    Min = table.Column<double>(type: "REAL", nullable: false),
                    Max = table.Column<double>(type: "REAL", nullable: false),
                    Night = table.Column<double>(type: "REAL", nullable: false),
                    Eve = table.Column<double>(type: "REAL", nullable: false),
                    Morn = table.Column<double>(type: "REAL", nullable: false),
                    DailyForecastId = table.Column<long>(type: "INTEGER", nullable: true),
                    DailyForecast = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temperatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Temperatures_DailyForecasts_DailyForecast",
                        column: x => x.DailyForecast,
                        principalTable: "DailyForecasts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rain",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    _1h = table.Column<double>(type: "REAL", nullable: true),
                    CurrentWeatherId = table.Column<long>(type: "INTEGER", nullable: true),
                    HourlyForecastId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rain_CurrentWeather_CurrentWeatherId",
                        column: x => x.CurrentWeatherId,
                        principalTable: "CurrentWeather",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rain_HourlyForecasts_HourlyForecastId",
                        column: x => x.HourlyForecastId,
                        principalTable: "HourlyForecasts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Snow",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    _1h = table.Column<double>(type: "REAL", nullable: true),
                    CurrentWeatherId = table.Column<long>(type: "INTEGER", nullable: true),
                    HourlyForecastId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Snow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Snow_CurrentWeather_CurrentWeatherId",
                        column: x => x.CurrentWeatherId,
                        principalTable: "CurrentWeather",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Snow_HourlyForecasts_HourlyForecastId",
                        column: x => x.HourlyForecastId,
                        principalTable: "HourlyForecasts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Weather",
                columns: table => new
                {
                    UniqueId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Id = table.Column<long>(type: "INTEGER", nullable: false),
                    Main = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Icon = table.Column<string>(type: "TEXT", nullable: false),
                    CurrentWeatherIdWeather = table.Column<long>(type: "INTEGER", nullable: true),
                    WeatherIdDailyForecast = table.Column<long>(type: "INTEGER", nullable: true),
                    WeatherIdHourlyForecast = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weather", x => x.UniqueId);
                    table.ForeignKey(
                        name: "FK_Weather_CurrentWeather_CurrentWeatherIdWeather",
                        column: x => x.CurrentWeatherIdWeather,
                        principalTable: "CurrentWeather",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Weather_DailyForecasts_WeatherIdDailyForecast",
                        column: x => x.WeatherIdDailyForecast,
                        principalTable: "DailyForecasts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Weather_HourlyForecasts_WeatherIdHourlyForecast",
                        column: x => x.WeatherIdHourlyForecast,
                        principalTable: "HourlyForecasts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alerts_WeatherDataId",
                table: "Alerts",
                column: "WeatherDataId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentWeather_WeatherDataId",
                table: "CurrentWeather",
                column: "WeatherDataId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DailyForecasts_WeatherDataId",
                table: "DailyForecasts",
                column: "WeatherDataId");

            migrationBuilder.CreateIndex(
                name: "IX_FeelsLikes_DailyForecastId",
                table: "FeelsLikes",
                column: "DailyForecastId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HourlyForecasts_WeatherDataId",
                table: "HourlyForecasts",
                column: "WeatherDataId");

            migrationBuilder.CreateIndex(
                name: "IX_MinutelyForecasts_WeatherDataId",
                table: "MinutelyForecasts",
                column: "WeatherDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Rain_CurrentWeatherId",
                table: "Rain",
                column: "CurrentWeatherId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rain_HourlyForecastId",
                table: "Rain",
                column: "HourlyForecastId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Snow_CurrentWeatherId",
                table: "Snow",
                column: "CurrentWeatherId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Snow_HourlyForecastId",
                table: "Snow",
                column: "HourlyForecastId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Temperatures_DailyForecast",
                table: "Temperatures",
                column: "DailyForecast",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Weather_CurrentWeatherIdWeather",
                table: "Weather",
                column: "CurrentWeatherIdWeather");

            migrationBuilder.CreateIndex(
                name: "IX_Weather_WeatherIdDailyForecast",
                table: "Weather",
                column: "WeatherIdDailyForecast");

            migrationBuilder.CreateIndex(
                name: "IX_Weather_WeatherIdHourlyForecast",
                table: "Weather",
                column: "WeatherIdHourlyForecast");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alerts");

            migrationBuilder.DropTable(
                name: "FeelsLikes");

            migrationBuilder.DropTable(
                name: "MinutelyForecasts");

            migrationBuilder.DropTable(
                name: "Rain");

            migrationBuilder.DropTable(
                name: "Snow");

            migrationBuilder.DropTable(
                name: "Temperatures");

            migrationBuilder.DropTable(
                name: "Weather");

            migrationBuilder.DropTable(
                name: "CurrentWeather");

            migrationBuilder.DropTable(
                name: "DailyForecasts");

            migrationBuilder.DropTable(
                name: "HourlyForecasts");

            migrationBuilder.DropTable(
                name: "WeatherData");
        }
    }
}
