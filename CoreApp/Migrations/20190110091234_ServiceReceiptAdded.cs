using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreApp.Migrations
{
    public partial class ServiceReceiptAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiceReceipts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ServiceReminderId = table.Column<string>(nullable: true),
                    CurrentMiles = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceReceipts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceReceipts_ServiceReminders_ServiceReminderId",
                        column: x => x.ServiceReminderId,
                        principalTable: "ServiceReminders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceReceipts_ServiceReminderId",
                table: "ServiceReceipts",
                column: "ServiceReminderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceReceipts");
        }
    }
}
