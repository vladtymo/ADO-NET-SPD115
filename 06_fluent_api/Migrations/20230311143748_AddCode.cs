using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _06_fluent_api.Migrations
{
    public partial class AddCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pages",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Countries");

            migrationBuilder.AddColumn<int>(
                name: "Pages",
                table: "Products",
                type: "int",
                nullable: true);
        }
    }
}
