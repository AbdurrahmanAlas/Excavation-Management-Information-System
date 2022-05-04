using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class content : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    ContentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContentValue = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ContentMahalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentAdaNo = table.Column<int>(type: "int", nullable: false),
                    ContentParselNo = table.Column<int>(type: "int", nullable: false),
                    ContentSonuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContentStatus = table.Column<bool>(type: "bit", nullable: false),
                    HeadingID = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: true),
                    WriterPersonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.ContentID);
                    table.ForeignKey(
                        name: "FK_Contents_Headings_HeadingID",
                        column: x => x.HeadingID,
                        principalTable: "Headings",
                        principalColumn: "HeadingID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contents_Users_WriterPersonId",
                        column: x => x.WriterPersonId,
                        principalTable: "Users",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contents_HeadingID",
                table: "Contents",
                column: "HeadingID");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_WriterPersonId",
                table: "Contents",
                column: "WriterPersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contents");
        }
    }
}
