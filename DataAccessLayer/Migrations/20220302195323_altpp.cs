using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class altpp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "İhaleDökuman",
                table: "AltyapıIslers",
                newName: "IhaleDökuman");

            migrationBuilder.AddColumn<DateTime>(
                name: "IhaleDate",
                table: "AltyapıIslers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IhaleDate",
                table: "AltyapıIslers");

            migrationBuilder.RenameColumn(
                name: "IhaleDökuman",
                table: "AltyapıIslers",
                newName: "İhaleDökuman");
        }
    }
}
