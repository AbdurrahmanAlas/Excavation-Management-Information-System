using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PersonSurName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PersonAbout = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PersonImage = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PersonMail = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PersonPassword = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PersonTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PersonStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.PersonId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
