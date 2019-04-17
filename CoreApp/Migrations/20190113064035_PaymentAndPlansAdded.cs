using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreApp.Migrations
{
    public partial class PaymentAndPlansAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentPlans",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    MonthsCovered = table.Column<int>(nullable: false),
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
                    PaymentPlanId = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    OwnedCarId = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true)
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
                    { "lifetime", 10000, "Purchase //productname for the life of the Vin, transferable", 9999, "", false }
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "PaymentPlans");
        }
    }
}
