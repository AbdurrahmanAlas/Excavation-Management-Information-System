using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class heading : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Headings",
                columns: table => new
                {
                    HeadingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeadingAdres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeadingAda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeadingParsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehiclePlaka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeadingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HeadingStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headings", x => x.HeadingID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Headings");
        }
    }
}
