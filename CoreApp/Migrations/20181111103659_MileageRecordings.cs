using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreApp.Migrations
{
	public partial class MileageRecordings : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AddColumn<string>(
				name: "Nickname",
				table: "OwnedCars",
				nullable: true);

			
			migrationBuilder.CreateTable(
				name: "MileageRecordings",
				columns: table => new
				{
					Id = table.Column<string>(nullable: false, maxLength:255),
					OwnedCarId = table.Column<string>(nullable: true, maxLength:255),
					RecordingDate = table.Column<DateTime>(nullable: false),
					Mileage = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_MileageRecordingDto", x => x.Id);
					table.ForeignKey(
						name: "FK_MileageRecordingDto_OwnedCars_OwnedCarId",
						column: x => x.OwnedCarId,
						principalTable: "OwnedCars",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
				});

			migrationBuilder.CreateIndex(
				name: "IX_MileageRecordingDto_OwnedCarId",
				table: "MileageRecordings",
				column: "OwnedCarId");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "MileageRecordings");

			migrationBuilder.DropColumn(
				name: "Nickname",
				table: "OwnedCars");
		}
	}
}
