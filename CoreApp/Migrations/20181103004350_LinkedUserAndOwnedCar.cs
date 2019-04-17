using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreApp.Migrations
{
    public partial class LinkedUserAndOwnedCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "OwnedCars",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OwnedCars_UserId",
                table: "OwnedCars",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnedCars_Users_UserId",
                table: "OwnedCars",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OwnedCars_Users_UserId",
                table: "OwnedCars");

            migrationBuilder.DropIndex(
                name: "IX_OwnedCars_UserId",
                table: "OwnedCars");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "OwnedCars");
        }
    }
}
