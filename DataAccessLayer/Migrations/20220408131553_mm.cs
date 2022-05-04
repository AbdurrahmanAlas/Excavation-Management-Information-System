using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "CompanyBalances",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "CompanyBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_CompanyBalances_CompanyId",
                table: "CompanyBalances",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyBalances_Companies_CompanyId",
                table: "CompanyBalances",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyBalances_Companies_CompanyId",
                table: "CompanyBalances");

            migrationBuilder.DropIndex(
                name: "IX_CompanyBalances_CompanyId",
                table: "CompanyBalances");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "CompanyBalances");

            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "CompanyBalances");
        }
    }
}
