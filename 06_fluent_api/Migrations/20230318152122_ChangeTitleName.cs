using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _06_fluent_api.Migrations
{
    public partial class ChangeTitleName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Products",
                newName: "Name");
        }
    }
}
