﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyWeatherDAL;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MyWeatherService.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20200425012236_LocationsFieldRequestableAdded")]
    partial class LocationsFieldRequestableAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("MyWeatherDAL.DTO.Weathers.FeelsLike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("Day")
                        .HasColumnType("double precision");

                    b.Property<double>("Eve")
                        .HasColumnType("double precision");

                    b.Property<double>("Morn")
                        .HasColumnType("double precision");

                    b.Property<double>("Night")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("FeelsLikes");
                });

            modelBuilder.Entity("MyWeatherDAL.DTO.Weathers.Temp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("Day")
                        .HasColumnType("double precision");

                    b.Property<double>("Eve")
                        .HasColumnType("double precision");

                    b.Property<double>("Max")
                        .HasColumnType("double precision");

                    b.Property<double>("Min")
                        .HasColumnType("double precision");

                    b.Property<double>("Morn")
                        .HasColumnType("double precision");

                    b.Property<double>("Night")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Temps");
                });

            modelBuilder.Entity("MyWeatherDAL.DTO.Weathers.Weather", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("Clouds")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("DewPoint")
                        .HasColumnType("double precision");

                    b.Property<double>("FeelsLike")
                        .HasColumnType("double precision");

                    b.Property<long>("Humidity")
                        .HasColumnType("bigint");

                    b.Property<long>("Pressure")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("SunriseDT")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("SunsetDT")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("Temp")
                        .HasColumnType("double precision");

                    b.Property<double>("Uvi")
                        .HasColumnType("double precision");

                    b.Property<long>("Visibility")
                        .HasColumnType("bigint");

                    b.Property<int?>("WeatherSummaryId")
                        .HasColumnType("integer");

                    b.Property<int?>("WeatherSummaryId1")
                        .HasColumnType("integer");

                    b.Property<long>("WindDeg")
                        .HasColumnType("bigint");

                    b.Property<long>("WindSpeed")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("WeatherSummaryId");

                    b.HasIndex("WeatherSummaryId1");

                    b.ToTable("Weathers");
                });

            modelBuilder.Entity("MyWeatherDAL.DTO.Weathers.WeatherDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Icon")
                        .HasColumnType("text");

                    b.Property<string>("Main")
                        .HasColumnType("text");

                    b.Property<int?>("WeatherId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("WeatherId");

                    b.ToTable("WeatherDescriptions");
                });

            modelBuilder.Entity("MyWeatherDAL.DTO.Weathers.WeatherSummary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CurrentId")
                        .HasColumnType("integer");

                    b.Property<double>("Lat")
                        .HasColumnType("double precision");

                    b.Property<int>("LocationId")
                        .HasColumnType("integer");

                    b.Property<double>("Lon")
                        .HasColumnType("double precision");

                    b.Property<string>("Timezone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CurrentId");

                    b.ToTable("WeatherSummaries");
                });

            modelBuilder.Entity("MyWeatherDAL.Models.Locations.Annotations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("Callingcode")
                        .HasColumnType("bigint");

                    b.Property<int?>("CurrencyId")
                        .HasColumnType("integer");

                    b.Property<int?>("DmsId")
                        .HasColumnType("integer");

                    b.Property<string>("Flag")
                        .HasColumnType("text");

                    b.Property<string>("Geohash")
                        .HasColumnType("text");

                    b.Property<int?>("MercatorId")
                        .HasColumnType("integer");

                    b.Property<int?>("OsmId")
                        .HasColumnType("integer");

                    b.Property<int?>("SunId")
                        .HasColumnType("integer");

                    b.Property<int?>("TimezoneId")
                        .HasColumnType("integer");

                    b.Property<int?>("What3WordsId")
                        .HasColumnType("integer");

                    b.Property<string>("Wikidata")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("DmsId");

                    b.HasIndex("MercatorId");

                    b.HasIndex("OsmId");

                    b.HasIndex("SunId");

                    b.HasIndex("TimezoneId");

                    b.HasIndex("What3WordsId");

                    b.ToTable("Annotations");
                });

            modelBuilder.Entity("MyWeatherDAL.Models.Locations.Components", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Category")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Continent")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("CountryCode")
                        .HasColumnType("text");

                    b.Property<string>("County")
                        .HasColumnType("text");

                    b.Property<string>("Iso31661_Alpha2")
                        .HasColumnType("text");

                    b.Property<string>("Iso31661_Alpha3")
                        .HasColumnType("text");

                    b.Property<long>("Postcode")
                        .HasColumnType("bigint");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("MyWeatherDAL.Models.Locations.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<List<string>>("AlternateSymbols")
                        .HasColumnType("text[]");

                    b.Property<string>("DecimalMark")
                        .HasColumnType("text");

                    b.Property<string>("HtmlEntity")
                        .HasColumnType("text");

                    b.Property<string>("IsoCode")
                        .HasColumnType("text");

                    b.Property<long>("IsoNumeric")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<long>("SmallestDenomination")
                        .HasColumnType("bigint");

                    b.Property<string>("Subunit")
                        .HasColumnType("text");

                    b.Property<long>("SubunitToUnit")
                        .HasColumnType("bigint");

                    b.Property<string>("Symbol")
                        .HasColumnType("text");

                    b.Property<long>("SymbolFirst")
                        .HasColumnType("bigint");

                    b.Property<string>("ThousandsSeparator")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("MyWeatherDAL.Models.Locations.Dms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Lat")
                        .HasColumnType("text");

                    b.Property<string>("Lng")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Dms");
                });

            modelBuilder.Entity("MyWeatherDAL.Models.Locations.Geometry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("Lat")
                        .HasColumnType("double precision");

                    b.Property<double>("Lng")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Geometries");
                });

            modelBuilder.Entity("MyWeatherDAL.Models.Locations.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("AnnotationsId")
                        .HasColumnType("integer");

                    b.Property<int?>("ComponentsId")
                        .HasColumnType("integer");

                    b.Property<long>("Confidence")
                        .HasColumnType("bigint");

                    b.Property<bool>("Current")
                        .HasColumnType("boolean");

                    b.Property<string>("Formatted")
                        .HasColumnType("text");

                    b.Property<int?>("GeometryId")
                        .HasColumnType("integer");

                    b.Property<bool>("Requestable")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("AnnotationsId");

                    b.HasIndex("ComponentsId");

                    b.HasIndex("GeometryId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("MyWeatherDAL.Models.Locations.Mercator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("X")
                        .HasColumnType("double precision");

                    b.Property<double>("Y")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Mercators");
                });

            modelBuilder.Entity("MyWeatherDAL.Models.Locations.Osm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("EditUrl")
                        .HasColumnType("text");

                    b.Property<string>("NoteUrl")
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Osms");
                });

            modelBuilder.Entity("MyWeatherDAL.Models.Locations.Rise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("Apparent")
                        .HasColumnType("bigint");

                    b.Property<long>("Astronomical")
                        .HasColumnType("bigint");

                    b.Property<long>("Civil")
                        .HasColumnType("bigint");

                    b.Property<long>("Nautical")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Rises");
                });

            modelBuilder.Entity("MyWeatherDAL.Models.Locations.Sun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("RiseId")
                        .HasColumnType("integer");

                    b.Property<int?>("SetId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RiseId");

                    b.HasIndex("SetId");

                    b.ToTable("Suns");
                });

            modelBuilder.Entity("MyWeatherDAL.Models.Locations.Timezone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<long>("NowInDst")
                        .HasColumnType("bigint");

                    b.Property<long>("OffsetSec")
                        .HasColumnType("bigint");

                    b.Property<string>("OffsetString")
                        .HasColumnType("text");

                    b.Property<string>("ShortName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Timezones");
                });

            modelBuilder.Entity("MyWeatherDAL.Models.Locations.What3Words", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Words")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("What3Words");
                });

            modelBuilder.Entity("MyWeatherDAL.DTO.Weathers.Weather", b =>
                {
                    b.HasOne("MyWeatherDAL.DTO.Weathers.WeatherSummary", null)
                        .WithMany("Daily")
                        .HasForeignKey("WeatherSummaryId");

                    b.HasOne("MyWeatherDAL.DTO.Weathers.WeatherSummary", null)
                        .WithMany("Hourly")
                        .HasForeignKey("WeatherSummaryId1");
                });

            modelBuilder.Entity("MyWeatherDAL.DTO.Weathers.WeatherDescription", b =>
                {
                    b.HasOne("MyWeatherDAL.DTO.Weathers.Weather", null)
                        .WithMany("WeatherDescription")
                        .HasForeignKey("WeatherId");
                });

            modelBuilder.Entity("MyWeatherDAL.DTO.Weathers.WeatherSummary", b =>
                {
                    b.HasOne("MyWeatherDAL.DTO.Weathers.Weather", "Current")
                        .WithMany()
                        .HasForeignKey("CurrentId");
                });

            modelBuilder.Entity("MyWeatherDAL.Models.Locations.Annotations", b =>
                {
                    b.HasOne("MyWeatherDAL.Models.Locations.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId");

                    b.HasOne("MyWeatherDAL.Models.Locations.Dms", "Dms")
                        .WithMany()
                        .HasForeignKey("DmsId");

                    b.HasOne("MyWeatherDAL.Models.Locations.Mercator", "Mercator")
                        .WithMany()
                        .HasForeignKey("MercatorId");

                    b.HasOne("MyWeatherDAL.Models.Locations.Osm", "Osm")
                        .WithMany()
                        .HasForeignKey("OsmId");

                    b.HasOne("MyWeatherDAL.Models.Locations.Sun", "Sun")
                        .WithMany()
                        .HasForeignKey("SunId");

                    b.HasOne("MyWeatherDAL.Models.Locations.Timezone", "Timezone")
                        .WithMany()
                        .HasForeignKey("TimezoneId");

                    b.HasOne("MyWeatherDAL.Models.Locations.What3Words", "What3Words")
                        .WithMany()
                        .HasForeignKey("What3WordsId");
                });

            modelBuilder.Entity("MyWeatherDAL.Models.Locations.Location", b =>
                {
                    b.HasOne("MyWeatherDAL.Models.Locations.Annotations", "Annotations")
                        .WithMany()
                        .HasForeignKey("AnnotationsId");

                    b.HasOne("MyWeatherDAL.Models.Locations.Components", "Components")
                        .WithMany()
                        .HasForeignKey("ComponentsId");

                    b.HasOne("MyWeatherDAL.Models.Locations.Geometry", "Geometry")
                        .WithMany()
                        .HasForeignKey("GeometryId");
                });

            modelBuilder.Entity("MyWeatherDAL.Models.Locations.Sun", b =>
                {
                    b.HasOne("MyWeatherDAL.Models.Locations.Rise", "Rise")
                        .WithMany()
                        .HasForeignKey("RiseId");

                    b.HasOne("MyWeatherDAL.Models.Locations.Rise", "Set")
                        .WithMany()
                        .HasForeignKey("SetId");
                });
#pragma warning restore 612, 618
        }
    }
}
