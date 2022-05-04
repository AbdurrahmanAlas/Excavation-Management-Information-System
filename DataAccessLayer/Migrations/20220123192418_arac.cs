using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class arac : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AracVehicleId",
                table: "Punishments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Aracs",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleBrand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehiclePlaka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleTip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleHGS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleIMEI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleDara = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleIzinBitis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoumentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aracs", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_Aracs_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Punishments_AracVehicleId",
                table: "Punishments",
                column: "AracVehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Aracs_CompanyId",
                table: "Aracs",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Punishments_Aracs_AracVehicleId",
                table: "Punishments",
                column: "AracVehicleId",
                principalTable: "Aracs",
                principalColumn: "VehicleId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Punishments_Aracs_AracVehicleId",
                table: "Punishments");

            migrationBuilder.DropTable(
                name: "Aracs");

            migrationBuilder.DropIndex(
                name: "IX_Punishments_AracVehicleId",
                table: "Punishments");

            migrationBuilder.DropColumn(
                name: "AracVehicleId",
                table: "Punishments");
        }
    }
}
