using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreApp.Migrations
{
    public partial class CustomerId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_PaymentPlans_PaymentPlanId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "PaymentPlans");

            migrationBuilder.DropIndex(
                name: "IX_Users_PaymentPlanId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "PaymentPlanId",
                table: "Users",
                newName: "StripeId");

            migrationBuilder.AlterColumn<string>(
                name: "StripeId",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StripeId",
                table: "Users",
                newName: "PaymentPlanId");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentPlanId",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "PaymentPlans",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    MonthsCovered = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Repeatable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    OwnedCarId = table.Column<string>(nullable: true),
                    PaymentPlanId = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_OwnedCars_OwnedCarId",
                        column: x => x.OwnedCarId,
                        principalTable: "OwnedCars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_PaymentPlans_PaymentPlanId",
                        column: x => x.PaymentPlanId,
                        principalTable: "PaymentPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "PaymentPlans",
                columns: new[] { "Id", "Amount", "Description", "MonthsCovered", "Name", "Repeatable" },
                values: new object[,]
                {
                    { "free trial", 0, "Test out the application to see how healthy your car is before you commit", 1, "Free Trial", false },
                    { "monthly", 100, "Pay for //productname on a monthly basis", 1, "Monthly Plan", true },
                    { "annual", 1000, "Pay for //productname on a yearly basis and get two month free", 12, "Annual", true },
                    { "lifetime", 10000, "Purchase //productname for the life of the Vin, transferable", 9999, "Lifetime", false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_PaymentPlanId",
                table: "Users",
                column: "PaymentPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OwnedCarId",
                table: "Payments",
                column: "OwnedCarId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentPlanId",
                table: "Payments",
                column: "PaymentPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_UserId",
                table: "Payments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_PaymentPlans_PaymentPlanId",
                table: "Users",
                column: "PaymentPlanId",
                principalTable: "PaymentPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
