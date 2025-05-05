using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperShop.Migrations
{
    public partial class RenomearImagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImgeUrl",
                table: "Products",
                newName: "ImageUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Products",
                newName: "ImgeUrl");
        }
    }
}
