using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class BalanceSmall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BalanceSmalls",
                columns: table => new
                {
                    BalanceSmallId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleNumber = table.Column<int>(type: "int", nullable: false),
                    TahakkukMiktarı = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Island = table.Column<int>(type: "int", nullable: false),
                    Parcel = table.Column<int>(type: "int", nullable: false),
                    miktar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SmallVehicleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalanceSmalls", x => x.BalanceSmallId);
                    table.ForeignKey(
                        name: "FK_BalanceSmalls_SmallVehicles_SmallVehicleId",
                        column: x => x.SmallVehicleId,
                        principalTable: "SmallVehicles",
                        principalColumn: "SmallVehicleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BalanceSmalls_SmallVehicleId",
                table: "BalanceSmalls",
                column: "SmallVehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BalanceSmalls");
        }
    }
}
