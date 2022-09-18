using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CmsServer.Migrations
{
    public partial class ozet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ozet",
                table: "Makale",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ozet",
                table: "Makale");
        }
    }
}
