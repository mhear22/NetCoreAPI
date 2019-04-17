using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreApp.Migrations
{
    public partial class ExpandedServiceTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Premium",
                table: "ServiceTypes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ServiceTypes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceTypes_UserId",
                table: "ServiceTypes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceTypes_Users_UserId",
                table: "ServiceTypes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceTypes_Users_UserId",
                table: "ServiceTypes");

            migrationBuilder.DropIndex(
                name: "IX_ServiceTypes_UserId",
                table: "ServiceTypes");

            migrationBuilder.DropColumn(
                name: "Premium",
                table: "ServiceTypes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ServiceTypes");
        }
    }
}
