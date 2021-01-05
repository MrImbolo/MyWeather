using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWeatherService.Migrations
{
    public partial class CurrencyModifiedIsoMetricSetString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IsoNumeric",
                table: "Currencies",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "IsoNumeric",
                table: "Currencies",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
