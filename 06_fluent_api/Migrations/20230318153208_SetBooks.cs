using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _06_fluent_api.Migrations
{
    public partial class SetBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Number", "GenreId", "Rating", "Title", "PublishYear" },
                values: new object[,]
                {
                    { 1, 4, 9.1f, "Da Vinci Code,The", 2005 },
                    { 2, 1, 5.6f, "Angels and Demons", 2015 },
                    { 3, 2, 7.1f, "Harry Potter and the Goblet of Fire", 1997 },
                    { 4, 2, 9.8f, "Fifty Shades of Grey", 2010 },
                    { 5, 1, 6.7f, "Twilight", 2022 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Number",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Number",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Number",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Number",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Number",
                keyValue: 5);
        }
    }
}
