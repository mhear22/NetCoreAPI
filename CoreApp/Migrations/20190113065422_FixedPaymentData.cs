using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreApp.Migrations
{
    public partial class FixedPaymentData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PaymentPlans",
                keyColumn: "Id",
                keyValue: "lifetime",
                column: "Name",
                value: "Lifetime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PaymentPlans",
                keyColumn: "Id",
                keyValue: "lifetime",
                column: "Name",
                value: "");
        }
    }
}
