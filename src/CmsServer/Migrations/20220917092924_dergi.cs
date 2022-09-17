using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CmsServer.Migrations
{
    public partial class dergi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dergi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dergi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sayi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DergiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    No = table.Column<int>(type: "int", nullable: false),
                    YayinTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sayi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sayi_Dergi_DergiId",
                        column: x => x.DergiId,
                        principalTable: "Dergi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Makale",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SayiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Makale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Makale_Sayi_SayiId",
                        column: x => x.SayiId,
                        principalTable: "Sayi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Makale_SayiId",
                table: "Makale",
                column: "SayiId");

            migrationBuilder.CreateIndex(
                name: "IX_Sayi_DergiId",
                table: "Sayi",
                column: "DergiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Makale");

            migrationBuilder.DropTable(
                name: "Sayi");

            migrationBuilder.DropTable(
                name: "Dergi");
        }
    }
}
