using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CmsServer.Migrations
{
    public partial class dergi_ozet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Dergi",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Dergi");
        }
    }
}
