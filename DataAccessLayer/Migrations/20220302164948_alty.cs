using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class alty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProjectDökuman",
                table: "AltyapıIslers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "İhaleDökuman",
                table: "AltyapıIslers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectDökuman",
                table: "AltyapıIslers");

            migrationBuilder.DropColumn(
                name: "İhaleDökuman",
                table: "AltyapıIslers");
        }
    }
}
