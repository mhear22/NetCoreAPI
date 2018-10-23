using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreApp.Migrations
{
    public partial class VinTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VinVDSs",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Matcher = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VinVDSs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VinVISs",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Matcher = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VinVISs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VinWMIs",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Matcher = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VinWMIs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VinVDSs");

            migrationBuilder.DropTable(
                name: "VinVISs");

            migrationBuilder.DropTable(
                name: "VinWMIs");
        }
    }
}
