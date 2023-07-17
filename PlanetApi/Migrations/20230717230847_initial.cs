using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlanetApi.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistanceFromSun = table.Column<double>(type: "float", nullable: false),
                    Mass = table.Column<double>(type: "float", nullable: false),
                    Diameter = table.Column<int>(type: "int", nullable: false),
                    AdditionalInformation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "AdditionalInformation", "Diameter", "DistanceFromSun", "ImageUrl", "Mass", "Name" },
                values: new object[,]
                {
                    { 1, null, 4879, 57.899999999999999, "https://scx2.b-cdn.net/gfx/news/hires/2015/whatsimporta.jpg", 0.33000000000000002, "Mercury" },
                    { 2, null, 12104, 108.2, "https://res.cloudinary.com/dk-find-out/image/upload/q_80,w_1920,f_auto/AW_Venus_nli6oy.jpg", 4.8700000000000001, "Venus" },
                    { 3, null, 12756, 149.59999999999999, "https://www.esa.int/var/esa/storage/images/esa_multimedia/images/2023/04/earth_30_year_comparison/24832556-1-eng-GB/Earth_30_year_comparison_pillars.jpg", 5.9699999999999998, "Earth" },
                    { 4, null, 6792, 228.0, "https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/Mars_Valles_Marineris.jpeg/1024px-Mars_Valles_Marineris.jpeg", 0.072999999999999995, "Mars" },
                    { 5, null, 142984, 778.5, "https://www.nasa.gov/sites/default/files/thumbnails/image/jupapr3color-jd-170304_0.png", 1898.0, "Jupiter" },
                    { 6, null, 120536, 1432.0, "https://scx2.b-cdn.net/gfx/news/hires/2023/new-image-from-james-w.jpg", 568.0, "Saturn" },
                    { 7, null, 51118, 2867.0, "https://solarsystem.nasa.gov/internal_resources/6038/uranushero.jpg", 86.0, "Uranus" },
                    { 8, null, 49528, 4515.0, "https://universemagazine.com/wp-content/uploads/2019/08/Neptune_-_August_20_1989_30686826283.jpg", 102.0, "Neptune" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planets");
        }
    }
}
