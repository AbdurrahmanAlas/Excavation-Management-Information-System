using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class companybalanceupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "CompanyBalances",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Island",
                table: "CompanyBalances",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Parcel",
                table: "CompanyBalances",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "miktar",
                table: "CompanyBalances",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CompanyBalance",
                table: "Companies",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "District",
                table: "CompanyBalances");

            migrationBuilder.DropColumn(
                name: "Island",
                table: "CompanyBalances");

            migrationBuilder.DropColumn(
                name: "Parcel",
                table: "CompanyBalances");

            migrationBuilder.DropColumn(
                name: "miktar",
                table: "CompanyBalances");

            migrationBuilder.DropColumn(
                name: "CompanyBalance",
                table: "Companies");
        }
    }
}
