using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreApp.Migrations
{
    public partial class ExpandedPremiumTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: "brakes",
                column: "Premium",
                value: true);

            migrationBuilder.UpdateData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: "coolant",
                column: "Premium",
                value: true);

            migrationBuilder.UpdateData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: "oilchange",
                column: "Premium",
                value: true);

            migrationBuilder.UpdateData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: "timing",
                column: "Premium",
                value: true);

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "Name", "Premium", "UserId" },
                values: new object[,]
                {
                    { "rego", "Renew Registration", false, null },
                    { "generalservice", "General Service Reminder", false, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: "generalservice");

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: "rego");

            migrationBuilder.UpdateData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: "brakes",
                column: "Premium",
                value: false);

            migrationBuilder.UpdateData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: "coolant",
                column: "Premium",
                value: false);

            migrationBuilder.UpdateData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: "oilchange",
                column: "Premium",
                value: false);

            migrationBuilder.UpdateData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: "timing",
                column: "Premium",
                value: false);
        }
    }
}
