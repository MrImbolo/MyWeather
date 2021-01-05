using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MyWeatherService.Migrations
{
    public partial class AddedDailyParams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weathers_WeatherSummaries_WeatherSummaryId1",
                table: "Weathers");

            migrationBuilder.DropIndex(
                name: "IX_Weathers_WeatherSummaryId1",
                table: "Weathers");

            migrationBuilder.DropColumn(
                name: "WeatherSummaryId1",
                table: "Weathers");

            migrationBuilder.AddColumn<int>(
                name: "DailyWeatherId",
                table: "WeatherDescriptions",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DailyWeather",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SunriseDT = table.Column<DateTime>(nullable: false),
                    SunsetDT = table.Column<DateTime>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    TempId = table.Column<int>(nullable: true),
                    FeelsLikeId = table.Column<int>(nullable: true),
                    Pressure = table.Column<long>(nullable: false),
                    Humidity = table.Column<long>(nullable: false),
                    DewPoint = table.Column<double>(nullable: false),
                    Uvi = table.Column<double>(nullable: false),
                    Clouds = table.Column<long>(nullable: false),
                    Visibility = table.Column<long>(nullable: false),
                    WindSpeed = table.Column<long>(nullable: false),
                    WindDeg = table.Column<long>(nullable: false),
                    WeatherSummaryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyWeather", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DailyWeather_FeelsLikes_FeelsLikeId",
                        column: x => x.FeelsLikeId,
                        principalTable: "FeelsLikes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DailyWeather_Temps_TempId",
                        column: x => x.TempId,
                        principalTable: "Temps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DailyWeather_WeatherSummaries_WeatherSummaryId",
                        column: x => x.WeatherSummaryId,
                        principalTable: "WeatherSummaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeatherDescriptions_DailyWeatherId",
                table: "WeatherDescriptions",
                column: "DailyWeatherId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyWeather_FeelsLikeId",
                table: "DailyWeather",
                column: "FeelsLikeId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyWeather_TempId",
                table: "DailyWeather",
                column: "TempId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyWeather_WeatherSummaryId",
                table: "DailyWeather",
                column: "WeatherSummaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherDescriptions_DailyWeather_DailyWeatherId",
                table: "WeatherDescriptions",
                column: "DailyWeatherId",
                principalTable: "DailyWeather",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeatherDescriptions_DailyWeather_DailyWeatherId",
                table: "WeatherDescriptions");

            migrationBuilder.DropTable(
                name: "DailyWeather");

            migrationBuilder.DropIndex(
                name: "IX_WeatherDescriptions_DailyWeatherId",
                table: "WeatherDescriptions");

            migrationBuilder.DropColumn(
                name: "DailyWeatherId",
                table: "WeatherDescriptions");

            migrationBuilder.AddColumn<int>(
                name: "WeatherSummaryId1",
                table: "Weathers",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Weathers_WeatherSummaryId1",
                table: "Weathers",
                column: "WeatherSummaryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Weathers_WeatherSummaries_WeatherSummaryId1",
                table: "Weathers",
                column: "WeatherSummaryId1",
                principalTable: "WeatherSummaries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
