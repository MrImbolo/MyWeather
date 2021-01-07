using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWeatherService.Migrations
{
    public partial class LinkWeatherSummaryToLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SunriseDT",
                table: "Weathers");

            migrationBuilder.DropColumn(
                name: "SunsetDT",
                table: "Weathers");

            migrationBuilder.AlterColumn<double>(
                name: "WindSpeed",
                table: "Weathers",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<DateTime>(
                name: "Sunrise",
                table: "Weathers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Sunset",
                table: "Weathers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_WeatherSummaries_LocationId",
                table: "WeatherSummaries",
                column: "LocationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherSummaries_Locations_LocationId",
                table: "WeatherSummaries",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeatherSummaries_Locations_LocationId",
                table: "WeatherSummaries");

            migrationBuilder.DropIndex(
                name: "IX_WeatherSummaries_LocationId",
                table: "WeatherSummaries");

            migrationBuilder.DropColumn(
                name: "Sunrise",
                table: "Weathers");

            migrationBuilder.DropColumn(
                name: "Sunset",
                table: "Weathers");

            migrationBuilder.AlterColumn<long>(
                name: "WindSpeed",
                table: "Weathers",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AddColumn<DateTime>(
                name: "SunriseDT",
                table: "Weathers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SunsetDT",
                table: "Weathers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
