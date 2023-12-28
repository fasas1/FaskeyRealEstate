using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FaskeyAtlantic.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedEstateToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Estates",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "Name", "Occupancy", "Price", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, "Neatly used 2 bedroom penthouse.  Unit - The unit covers the entire floor, with two massive balconies in front and back, you may decided to add additional rooms in front if you wish but you are not allowed to\r\nadd another floor as the approved amount of floors within the estate is four(4).Content from Nigeria Property Centre", "https://www.pexels.com/photo/blue-lounger-beside-swimming-pool-221457/", "Banana Ville Resort", 0, 4800.0, 1700, null },
                    { 2, null, "Neatly used 3 bedroom. invater - The unit comes with 20-solar panels and 10kva invater - this invater lasts for 12hours and it takes 2 A/cs but all units A/cs are connected to it, you decide which 2 A/cs to leave ON . But\r\nthe light in Osborne Forshore is superb - 23hours and most times it goes for days.Content from Nigeria Property Centre", "https://www.pexels.com/photo/construction-house-architecture-luxury-53610/", "Exclusive Luxury Mansion", 0, 3800.0, 1300, null },
                    { 3, null, "Neatly used 2 bedroom penthouse.  Unit - The unit covers the entire floor, with two massive balconies in front and back, you\r\nmay decided to add additional rooms in front if you wish but you are not allowed to\r\nadd another floor as the approved amount of floors within the estate is four(4).Content from Nigeria Property Centre", "https://www.pexels.com/photo/white-concrete-2-storey-house-206172/", "Shuqroh Ville", 0, 1400.0, 1100, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
