using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig89 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aracs_Companies_CompanyId",
                table: "Aracs");

            migrationBuilder.DropForeignKey(
                name: "FK_Punishments_Aracs_AracVehicleId",
                table: "Punishments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Aracs",
                table: "Aracs");

            migrationBuilder.RenameTable(
                name: "Aracs",
                newName: "Vehicles");

            migrationBuilder.RenameIndex(
                name: "IX_Aracs_CompanyId",
                table: "Vehicles",
                newName: "IX_Vehicles_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Punishments_Vehicles_AracVehicleId",
                table: "Punishments",
                column: "AracVehicleId",
                principalTable: "Vehicles",
                principalColumn: "VehicleId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Companies_CompanyId",
                table: "Vehicles",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Punishments_Vehicles_AracVehicleId",
                table: "Punishments");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Companies_CompanyId",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles");

            migrationBuilder.RenameTable(
                name: "Vehicles",
                newName: "Aracs");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_CompanyId",
                table: "Aracs",
                newName: "IX_Aracs_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Aracs",
                table: "Aracs",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aracs_Companies_CompanyId",
                table: "Aracs",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Punishments_Aracs_AracVehicleId",
                table: "Punishments",
                column: "AracVehicleId",
                principalTable: "Aracs",
                principalColumn: "VehicleId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
