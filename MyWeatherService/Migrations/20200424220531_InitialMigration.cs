using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MyWeatherService.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Components",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Iso31661_Alpha2 = table.Column<string>(nullable: true),
                    Iso31661_Alpha3 = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Continent = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    CountryCode = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Postcode = table.Column<long>(nullable: false),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Components", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AlternateSymbols = table.Column<List<string>>(nullable: true),
                    DecimalMark = table.Column<string>(nullable: true),
                    HtmlEntity = table.Column<string>(nullable: true),
                    IsoCode = table.Column<string>(nullable: true),
                    IsoNumeric = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SmallestDenomination = table.Column<long>(nullable: false),
                    Subunit = table.Column<string>(nullable: true),
                    SubunitToUnit = table.Column<long>(nullable: false),
                    Symbol = table.Column<string>(nullable: true),
                    SymbolFirst = table.Column<long>(nullable: false),
                    ThousandsSeparator = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Lat = table.Column<string>(nullable: true),
                    Lng = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeelsLikes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Day = table.Column<double>(nullable: false),
                    Night = table.Column<double>(nullable: false),
                    Eve = table.Column<double>(nullable: false),
                    Morn = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeelsLikes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Geometries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Lat = table.Column<double>(nullable: false),
                    Lng = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geometries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mercators",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    X = table.Column<double>(nullable: false),
                    Y = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mercators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Osms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EditUrl = table.Column<string>(nullable: true),
                    NoteUrl = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rises",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Apparent = table.Column<long>(nullable: false),
                    Astronomical = table.Column<long>(nullable: false),
                    Civil = table.Column<long>(nullable: false),
                    Nautical = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Temps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Day = table.Column<double>(nullable: false),
                    Min = table.Column<double>(nullable: false),
                    Max = table.Column<double>(nullable: false),
                    Night = table.Column<double>(nullable: false),
                    Eve = table.Column<double>(nullable: false),
                    Morn = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Timezones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    NowInDst = table.Column<long>(nullable: false),
                    OffsetSec = table.Column<long>(nullable: false),
                    OffsetString = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timezones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "What3Words",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Words = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_What3Words", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RiseId = table.Column<int>(nullable: true),
                    SetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suns_Rises_RiseId",
                        column: x => x.RiseId,
                        principalTable: "Rises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Suns_Rises_SetId",
                        column: x => x.SetId,
                        principalTable: "Rises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Annotations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DmsId = table.Column<int>(nullable: true),
                    MercatorId = table.Column<int>(nullable: true),
                    OsmId = table.Column<int>(nullable: true),
                    Callingcode = table.Column<long>(nullable: false),
                    CurrencyId = table.Column<int>(nullable: true),
                    Flag = table.Column<string>(nullable: true),
                    Geohash = table.Column<string>(nullable: true),
                    SunId = table.Column<int>(nullable: true),
                    TimezoneId = table.Column<int>(nullable: true),
                    What3WordsId = table.Column<int>(nullable: true),
                    Wikidata = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Annotations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Annotations_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Annotations_Dms_DmsId",
                        column: x => x.DmsId,
                        principalTable: "Dms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Annotations_Mercators_MercatorId",
                        column: x => x.MercatorId,
                        principalTable: "Mercators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Annotations_Osms_OsmId",
                        column: x => x.OsmId,
                        principalTable: "Osms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Annotations_Suns_SunId",
                        column: x => x.SunId,
                        principalTable: "Suns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Annotations_Timezones_TimezoneId",
                        column: x => x.TimezoneId,
                        principalTable: "Timezones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Annotations_What3Words_What3WordsId",
                        column: x => x.What3WordsId,
                        principalTable: "What3Words",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AnnotationsId = table.Column<int>(nullable: true),
                    ComponentsId = table.Column<int>(nullable: true),
                    Confidence = table.Column<long>(nullable: false),
                    Formatted = table.Column<string>(nullable: true),
                    GeometryId = table.Column<int>(nullable: true),
                    Current = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Annotations_AnnotationsId",
                        column: x => x.AnnotationsId,
                        principalTable: "Annotations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Locations_Components_ComponentsId",
                        column: x => x.ComponentsId,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Locations_Geometries_GeometryId",
                        column: x => x.GeometryId,
                        principalTable: "Geometries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WeatherDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Main = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    WeatherId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherDescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeatherSummaries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Lat = table.Column<double>(nullable: false),
                    Lon = table.Column<double>(nullable: false),
                    Timezone = table.Column<string>(nullable: true),
                    CurrentId = table.Column<int>(nullable: true),
                    LocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherSummaries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weathers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SunriseDT = table.Column<DateTime>(nullable: false),
                    SunsetDT = table.Column<DateTime>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Temp = table.Column<double>(nullable: false),
                    FeelsLike = table.Column<double>(nullable: false),
                    Pressure = table.Column<long>(nullable: false),
                    Humidity = table.Column<long>(nullable: false),
                    DewPoint = table.Column<double>(nullable: false),
                    Uvi = table.Column<double>(nullable: false),
                    Clouds = table.Column<long>(nullable: false),
                    Visibility = table.Column<long>(nullable: false),
                    WindSpeed = table.Column<long>(nullable: false),
                    WindDeg = table.Column<long>(nullable: false),
                    WeatherSummaryId = table.Column<int>(nullable: true),
                    WeatherSummaryId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weathers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weathers_WeatherSummaries_WeatherSummaryId",
                        column: x => x.WeatherSummaryId,
                        principalTable: "WeatherSummaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Weathers_WeatherSummaries_WeatherSummaryId1",
                        column: x => x.WeatherSummaryId1,
                        principalTable: "WeatherSummaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Annotations_CurrencyId",
                table: "Annotations",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Annotations_DmsId",
                table: "Annotations",
                column: "DmsId");

            migrationBuilder.CreateIndex(
                name: "IX_Annotations_MercatorId",
                table: "Annotations",
                column: "MercatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Annotations_OsmId",
                table: "Annotations",
                column: "OsmId");

            migrationBuilder.CreateIndex(
                name: "IX_Annotations_SunId",
                table: "Annotations",
                column: "SunId");

            migrationBuilder.CreateIndex(
                name: "IX_Annotations_TimezoneId",
                table: "Annotations",
                column: "TimezoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Annotations_What3WordsId",
                table: "Annotations",
                column: "What3WordsId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_AnnotationsId",
                table: "Locations",
                column: "AnnotationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_ComponentsId",
                table: "Locations",
                column: "ComponentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_GeometryId",
                table: "Locations",
                column: "GeometryId");

            migrationBuilder.CreateIndex(
                name: "IX_Suns_RiseId",
                table: "Suns",
                column: "RiseId");

            migrationBuilder.CreateIndex(
                name: "IX_Suns_SetId",
                table: "Suns",
                column: "SetId");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherDescriptions_WeatherId",
                table: "WeatherDescriptions",
                column: "WeatherId");

            migrationBuilder.CreateIndex(
                name: "IX_Weathers_WeatherSummaryId",
                table: "Weathers",
                column: "WeatherSummaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Weathers_WeatherSummaryId1",
                table: "Weathers",
                column: "WeatherSummaryId1");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherSummaries_CurrentId",
                table: "WeatherSummaries",
                column: "CurrentId");

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherDescriptions_Weathers_WeatherId",
                table: "WeatherDescriptions",
                column: "WeatherId",
                principalTable: "Weathers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherSummaries_Weathers_CurrentId",
                table: "WeatherSummaries",
                column: "CurrentId",
                principalTable: "Weathers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeatherSummaries_Weathers_CurrentId",
                table: "WeatherSummaries");

            migrationBuilder.DropTable(
                name: "FeelsLikes");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Temps");

            migrationBuilder.DropTable(
                name: "WeatherDescriptions");

            migrationBuilder.DropTable(
                name: "Annotations");

            migrationBuilder.DropTable(
                name: "Components");

            migrationBuilder.DropTable(
                name: "Geometries");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Dms");

            migrationBuilder.DropTable(
                name: "Mercators");

            migrationBuilder.DropTable(
                name: "Osms");

            migrationBuilder.DropTable(
                name: "Suns");

            migrationBuilder.DropTable(
                name: "Timezones");

            migrationBuilder.DropTable(
                name: "What3Words");

            migrationBuilder.DropTable(
                name: "Rises");

            migrationBuilder.DropTable(
                name: "Weathers");

            migrationBuilder.DropTable(
                name: "WeatherSummaries");
        }
    }
}
