using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreApp.Migrations
{
    public partial class VinTablesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CountryId",
                table: "VinWMIs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManufacturerId",
                table: "VinWMIs",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CountryDto",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    VinPrefix = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryDto", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CountryDto",
                columns: new[] { "Id", "Name", "VinPrefix" },
                values: new object[] { "8b6e9487-db5b-4985-9852-ecca594d0024", "Australia", "6" });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Name", "VinPrefix" },
                values: new object[] { "8b6e9487-db5b-4985-9852-ecca594d0024", "Toyota", "" });

            migrationBuilder.InsertData(
                table: "VinWMIs",
                columns: new[] { "Id", "CountryId", "ManufacturerId", "Matcher" },
                values: new object[] { "8b6e9487-db5b-4985-9852-ecca594d0024", "8b6e9487-db5b-4985-9852-ecca594d0024", "8b6e9487-db5b-4985-9852-ecca594d0024", "6T1" });

            migrationBuilder.CreateIndex(
                name: "IX_VinWMIs_CountryId",
                table: "VinWMIs",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_VinWMIs_ManufacturerId",
                table: "VinWMIs",
                column: "ManufacturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_VinWMIs_CountryDto_CountryId",
                table: "VinWMIs",
                column: "CountryId",
                principalTable: "CountryDto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VinWMIs_Manufacturers_ManufacturerId",
                table: "VinWMIs",
                column: "ManufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VinWMIs_CountryDto_CountryId",
                table: "VinWMIs");

            migrationBuilder.DropForeignKey(
                name: "FK_VinWMIs_Manufacturers_ManufacturerId",
                table: "VinWMIs");

            migrationBuilder.DropTable(
                name: "CountryDto");

            migrationBuilder.DropIndex(
                name: "IX_VinWMIs_CountryId",
                table: "VinWMIs");

            migrationBuilder.DropIndex(
                name: "IX_VinWMIs_ManufacturerId",
                table: "VinWMIs");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0024");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0024");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "VinWMIs");

            migrationBuilder.DropColumn(
                name: "ManufacturerId",
                table: "VinWMIs");
        }
    }
}
