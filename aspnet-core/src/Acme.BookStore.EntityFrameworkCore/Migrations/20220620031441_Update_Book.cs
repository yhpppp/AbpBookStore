using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.BookStore.Migrations
{
    public partial class Update_Book : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "price",
                table: "AppBooks",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "AppBooks",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "AppBooks",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AppBooks",
                newName: "name");
        }
    }
}
