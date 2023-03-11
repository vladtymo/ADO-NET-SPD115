using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _06_fluent_api.Migrations
{
    public partial class AddPages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Pages",
                table: "Products",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pages",
                table: "Products");
        }
    }
}
