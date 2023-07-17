﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlanetsApi.Models;

#nullable disable

namespace PlanetApi.Migrations
{
    [DbContext(typeof(AstronomyDbContext))]
    [Migration("20230717230847_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PlanetsApi.Models.Planet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdditionalInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Diameter")
                        .HasColumnType("int");

                    b.Property<double>("DistanceFromSun")
                        .HasColumnType("float");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Mass")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Planets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Diameter = 4879,
                            DistanceFromSun = 57.899999999999999,
                            ImageUrl = "https://scx2.b-cdn.net/gfx/news/hires/2015/whatsimporta.jpg",
                            Mass = 0.33000000000000002,
                            Name = "Mercury"
                        },
                        new
                        {
                            Id = 2,
                            Diameter = 12104,
                            DistanceFromSun = 108.2,
                            ImageUrl = "https://res.cloudinary.com/dk-find-out/image/upload/q_80,w_1920,f_auto/AW_Venus_nli6oy.jpg",
                            Mass = 4.8700000000000001,
                            Name = "Venus"
                        },
                        new
                        {
                            Id = 3,
                            Diameter = 12756,
                            DistanceFromSun = 149.59999999999999,
                            ImageUrl = "https://www.esa.int/var/esa/storage/images/esa_multimedia/images/2023/04/earth_30_year_comparison/24832556-1-eng-GB/Earth_30_year_comparison_pillars.jpg",
                            Mass = 5.9699999999999998,
                            Name = "Earth"
                        },
                        new
                        {
                            Id = 4,
                            Diameter = 6792,
                            DistanceFromSun = 228.0,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/Mars_Valles_Marineris.jpeg/1024px-Mars_Valles_Marineris.jpeg",
                            Mass = 0.072999999999999995,
                            Name = "Mars"
                        },
                        new
                        {
                            Id = 5,
                            Diameter = 142984,
                            DistanceFromSun = 778.5,
                            ImageUrl = "https://www.nasa.gov/sites/default/files/thumbnails/image/jupapr3color-jd-170304_0.png",
                            Mass = 1898.0,
                            Name = "Jupiter"
                        },
                        new
                        {
                            Id = 6,
                            Diameter = 120536,
                            DistanceFromSun = 1432.0,
                            ImageUrl = "https://scx2.b-cdn.net/gfx/news/hires/2023/new-image-from-james-w.jpg",
                            Mass = 568.0,
                            Name = "Saturn"
                        },
                        new
                        {
                            Id = 7,
                            Diameter = 51118,
                            DistanceFromSun = 2867.0,
                            ImageUrl = "https://solarsystem.nasa.gov/internal_resources/6038/uranushero.jpg",
                            Mass = 86.0,
                            Name = "Uranus"
                        },
                        new
                        {
                            Id = 8,
                            Diameter = 49528,
                            DistanceFromSun = 4515.0,
                            ImageUrl = "https://universemagazine.com/wp-content/uploads/2019/08/Neptune_-_August_20_1989_30686826283.jpg",
                            Mass = 102.0,
                            Name = "Neptune"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}