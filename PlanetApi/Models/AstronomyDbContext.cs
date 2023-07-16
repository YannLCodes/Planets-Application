using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace PlanetsApi.Models
{
    public class AstronomyDbContext : DbContext
    {
        public AstronomyDbContext(DbContextOptions<AstronomyDbContext> options) : base(options)
        {
        }
        public DbSet<Planet> Planets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Department
            modelBuilder.Entity<Planet>()
                        .HasData(
                            // Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune.
                            new Planet
                            {
                                Id = 1,
                                Name = "Mercury",
                                ImageUrl = "",
                                DistanceFromSun = 57.9,
                                Mass = 0.330,
                                Diameter = 4879
                            },
                            new Planet
                            {
                                Id = 2,
                                Name = "Venus",
                                ImageUrl = "",
                                DistanceFromSun = 108.2,
                                Mass = 4.87,
                                Diameter = 12104
                            },
                            new Planet
                            {
                                Id = 3,
                                Name = "Earth",
                                ImageUrl = "",
                                DistanceFromSun = 149.6,
                                Mass = 5.97,
                                Diameter = 12756
                            },
                            new Planet
                            {
                                Id = 4,
                                Name = "Mars",
                                ImageUrl = "",
                                DistanceFromSun = 228,
                                Mass = 0.073,
                                Diameter = 6792
                            },
                            new Planet
                            {
                                Id = 5,
                                Name = "Jupiter",
                                ImageUrl = "",
                                DistanceFromSun = 778.5,
                                Mass = 1898,
                                Diameter = 142984
                            },
                            new Planet
                            {
                                Id = 6,
                                Name = "Saturn",
                                ImageUrl = "",
                                DistanceFromSun = 1432,
                                Mass = 568,
                                Diameter = 120536
                            },
                            new Planet
                            {
                                Id = 7,
                                Name = "Uranus",
                                ImageUrl = "",
                                DistanceFromSun = 2867,
                                Mass = 86,
                                Diameter = 51118
                            },
                            new Planet
                            {
                                Id = 8,
                                Name = "Neptune",
                                ImageUrl = "",
                                DistanceFromSun = 4515,
                                Mass = 102,
                                Diameter = 49528
                            }
                );
        }
    }
}
