using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreApp.Migrations
{
    public partial class ServiceReminderSystem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RepeatTypes",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepeatTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypes",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceReminders",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ServiceTypeId = table.Column<string>(nullable: true),
                    OwnedCarId = table.Column<string>(nullable: true),
                    RepeatingTypeId = table.Column<string>(nullable: true),
                    RepeatingFigure = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceReminders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceReminders_OwnedCars_OwnedCarId",
                        column: x => x.OwnedCarId,
                        principalTable: "OwnedCars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceReminders_RepeatTypes_RepeatingTypeId",
                        column: x => x.RepeatingTypeId,
                        principalTable: "RepeatTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceReminders_ServiceTypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "RepeatTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "age", "Age" },
                    { "mileage", "Mileage" }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "oilchange", "Oil Change" },
                    { "coolantflush", "Coolant Flush" },
                    { "timingbelt", "Replace Timing Equipment" },
                    { "brakes", "Check Brakes Depth" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceReminders_OwnedCarId",
                table: "ServiceReminders",
                column: "OwnedCarId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceReminders_RepeatingTypeId",
                table: "ServiceReminders",
                column: "RepeatingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceReminders_ServiceTypeId",
                table: "ServiceReminders",
                column: "ServiceTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MileageRecordings_OwnedCars_OwnedCarId",
                table: "MileageRecordings",
                column: "OwnedCarId",
                principalTable: "OwnedCars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MileageRecordings_OwnedCars_OwnedCarId",
                table: "MileageRecordings");

            migrationBuilder.DropTable(
                name: "ServiceReminders");

            migrationBuilder.DropTable(
                name: "RepeatTypes");

            migrationBuilder.DropTable(
                name: "ServiceTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MileageRecordings",
                table: "MileageRecordings");

            migrationBuilder.RenameTable(
                name: "MileageRecordings",
                newName: "MileageRecordingDto");

            migrationBuilder.RenameIndex(
                name: "IX_MileageRecordings_OwnedCarId",
                table: "MileageRecordingDto",
                newName: "IX_MileageRecordingDto_OwnedCarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MileageRecordingDto",
                table: "MileageRecordingDto",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MileageRecordingDto_OwnedCars_OwnedCarId",
                table: "MileageRecordingDto",
                column: "OwnedCarId",
                principalTable: "OwnedCars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
