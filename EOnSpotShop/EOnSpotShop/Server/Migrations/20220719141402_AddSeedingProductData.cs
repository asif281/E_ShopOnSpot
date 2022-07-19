using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EOnSpotShop.Server.Migrations
{
    public partial class AddSeedingProductData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Biochemistry is a common university textbook used for teaching of biochemistry. It was initially written by Lubert Stryer and published by W. H. Freeman in 1975.[1][2][3] It has been published in regular editions since.[4][5][6] It is commonly used as an undergraduate teaching textbook or reference work.[7]", "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e6/Bretherick_3_to_7_eds.jpg/300px-Bretherick_3_to_7_eds.jpg", 7.98m, "Biochemistry (book)" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "The Debian System is a 2005 non-fiction book written by Martin Krafft which deals exclusively with Debian Linux, detailing its internal workings. The book is mostly for the experienced users seeking in-depth technical knowledge, rather than for beginners.", "https://upload.wikimedia.org/wikipedia/en/5/57/Debian_System_Cover.png", 8.02m, "The Debian System" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
