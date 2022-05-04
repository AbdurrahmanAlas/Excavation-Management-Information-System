using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TexNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyTip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyTaxOffice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyDistrict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentTip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Complaints",
                columns: table => new
                {
                    ComplaintId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complainant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComplainantPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CloseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lookperson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Conclusion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Process = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaints", x => x.ComplaintId);
                    table.ForeignKey(
                        name: "FK_Complaints_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fillings",
                columns: table => new
                {
                    FillingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mahalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nereden = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nereye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartIsland = table.Column<int>(type: "int", nullable: false),
                    FınıshIsland = table.Column<int>(type: "int", nullable: false),
                    StartParcel = table.Column<int>(type: "int", nullable: false),
                    StartDistrict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FınıshDıstrıct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleNumber = table.Column<int>(type: "int", nullable: false),
                    Vehicle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TalepEden = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fillings", x => x.FillingId);
                    table.ForeignKey(
                        name: "FK_Fillings_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OtherStructures",
                columns: table => new
                {
                    OtherStructureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mahalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nereden = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nereye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartIsland = table.Column<int>(type: "int", nullable: false),
                    FınıshIsland = table.Column<int>(type: "int", nullable: false),
                    StartParcel = table.Column<int>(type: "int", nullable: false),
                    StartDistrict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FınıshDıstrıct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleNumber = table.Column<int>(type: "int", nullable: false),
                    Vehicle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TalepEden = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherStructures", x => x.OtherStructureId);
                    table.ForeignKey(
                        name: "FK_OtherStructures_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Structures",
                columns: table => new
                {
                    StructureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermitNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehiclePlaka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ÜreticiName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ÜreticiPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ÜreticiAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Island = table.Column<int>(type: "int", nullable: false),
                    Parcel = table.Column<int>(type: "int", nullable: false),
                    Blok = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mahalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Excavation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Filling = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmptyExcavation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Atıkcinsi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Casting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExcavationAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentTipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Structures", x => x.StructureId);
                    table.ForeignKey(
                        name: "FK_Structures_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
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
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_Vehicles_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Punishments",
                columns: table => new
                {
                    CezaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentTipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CezaTeam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CezaPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CezaAmont = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CezaDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    VehicleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Punishments", x => x.CezaId);
                    table.ForeignKey(
                        name: "FK_Punishments_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Punishments_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Complaints_CompanyId",
                table: "Complaints",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Fillings_CompanyId",
                table: "Fillings",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherStructures_CompanyId",
                table: "OtherStructures",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Punishments_CompanyId",
                table: "Punishments",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Punishments_VehicleId",
                table: "Punishments",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Structures_CompanyId",
                table: "Structures",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CompanyId",
                table: "Vehicles",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Complaints");

            migrationBuilder.DropTable(
                name: "Fillings");

            migrationBuilder.DropTable(
                name: "OtherStructures");

            migrationBuilder.DropTable(
                name: "Punishments");

            migrationBuilder.DropTable(
                name: "Structures");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
