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
                            new Planet
                            {
                                Id = 1,
                                Name = "Mercury",
                                ImageUrl = "https://scx2.b-cdn.net/gfx/news/hires/2015/whatsimporta.jpg",
                                DistanceFromSun = 57.9,
                                Mass = 0.330,
                                Diameter = 4879
                            },
                            new Planet
                            {
                                Id = 2,
                                Name = "Venus",
                                ImageUrl = "https://res.cloudinary.com/dk-find-out/image/upload/q_80,w_1920,f_auto/AW_Venus_nli6oy.jpg",
                                DistanceFromSun = 108.2,
                                Mass = 4.87,
                                Diameter = 12104
                            },
                            new Planet
                            {
                                Id = 3,
                                Name = "Earth",
                                ImageUrl = "https://www.esa.int/var/esa/storage/images/esa_multimedia/images/2023/04/earth_30_year_comparison/24832556-1-eng-GB/Earth_30_year_comparison_pillars.jpg",
                                DistanceFromSun = 149.6,
                                Mass = 5.97,
                                Diameter = 12756
                            },
                            new Planet
                            {
                                Id = 4,
                                Name = "Mars",
                                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/Mars_Valles_Marineris.jpeg/1024px-Mars_Valles_Marineris.jpeg",
                                DistanceFromSun = 228,
                                Mass = 0.073,
                                Diameter = 6792
                            },
                            new Planet
                            {
                                Id = 5,
                                Name = "Jupiter",
                                ImageUrl = "https://www.nasa.gov/sites/default/files/thumbnails/image/jupapr3color-jd-170304_0.png",
                                DistanceFromSun = 778.5,
                                Mass = 1898,
                                Diameter = 142984
                            },
                            new Planet
                            {
                                Id = 6,
                                Name = "Saturn",
                                ImageUrl = "https://scx2.b-cdn.net/gfx/news/hires/2023/new-image-from-james-w.jpg",
                                DistanceFromSun = 1432,
                                Mass = 568,
                                Diameter = 120536
                            },
                            new Planet
                            {
                                Id = 7,
                                Name = "Uranus",
                                ImageUrl = "https://solarsystem.nasa.gov/internal_resources/6038/uranushero.jpg",
                                DistanceFromSun = 2867,
                                Mass = 86,
                                Diameter = 51118
                            },
                            new Planet
                            {
                                Id = 8,
                                Name = "Neptune",
                                ImageUrl = "https://universemagazine.com/wp-content/uploads/2019/08/Neptune_-_August_20_1989_30686826283.jpg",
                                DistanceFromSun = 4515,
                                Mass = 102,
                                Diameter = 49528
                            }
                );
        }
    }
}
