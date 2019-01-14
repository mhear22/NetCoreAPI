using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreApp.Migrations
{
    public partial class PaymentPlanForUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PaymentPlanId",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_PaymentPlanId",
                table: "Users",
                column: "PaymentPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_PaymentPlans_PaymentPlanId",
                table: "Users",
                column: "PaymentPlanId",
                principalTable: "PaymentPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_PaymentPlans_PaymentPlanId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PaymentPlanId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PaymentPlanId",
                table: "Users");
        }
    }
}
