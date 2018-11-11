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
				name: "MileageRecordingDto",
				columns: table => new
				{
					Id = table.Column<string>(nullable: false),
					OwnedCarId = table.Column<string>(nullable: true),
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
				table: "MileageRecordingDto",
				column: "OwnedCarId");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "MileageRecordingDto");

			migrationBuilder.DropColumn(
				name: "Nickname",
				table: "OwnedCars");
		}
	}
}
