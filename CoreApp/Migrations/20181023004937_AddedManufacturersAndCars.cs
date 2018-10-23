using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreApp.Migrations
{
	public partial class AddedManufacturersAndCars : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropPrimaryKey(
				name: "PK_users",
				table: "users");

			migrationBuilder.DropPrimaryKey(
				name: "PK_sessions",
				table: "sessions");

			migrationBuilder.DropPrimaryKey(
				name: "PK_postTypes",
				table: "postTypes");

			migrationBuilder.DropPrimaryKey(
				name: "PK_posts",
				table: "posts");

			migrationBuilder.DropPrimaryKey(
				name: "PK_piece",
				table: "piece");

			migrationBuilder.DropPrimaryKey(
				name: "PK_passwords",
				table: "passwords");

			migrationBuilder.DropPrimaryKey(
				name: "PK_files",
				table: "files");

			migrationBuilder.DropPrimaryKey(
				name: "PK_filePieces",
				table: "filePieces");

			migrationBuilder.RenameTable(
				name: "users",
				newName: "Users");

			migrationBuilder.RenameTable(
				name: "sessions",
				newName: "Sessions");

			migrationBuilder.RenameTable(
				name: "postTypes",
				newName: "PostTypes");

			migrationBuilder.RenameTable(
				name: "posts",
				newName: "Posts");

			migrationBuilder.RenameTable(
				name: "piece",
				newName: "Piece");

			migrationBuilder.RenameTable(
				name: "passwords",
				newName: "Passwords");

			migrationBuilder.RenameTable(
				name: "files",
				newName: "Files");

			migrationBuilder.RenameTable(
				name: "filePieces",
				newName: "FilePieces");

			migrationBuilder.AddPrimaryKey(
				name: "PK_Users",
				table: "Users",
				column: "Id");

			migrationBuilder.AddPrimaryKey(
				name: "PK_Sessions",
				table: "Sessions",
				column: "Id");

			migrationBuilder.AddPrimaryKey(
				name: "PK_PostTypes",
				table: "PostTypes",
				column: "Id");

			migrationBuilder.AddPrimaryKey(
				name: "PK_Posts",
				table: "Posts",
				column: "Id");

			migrationBuilder.AddPrimaryKey(
				name: "PK_Piece",
				table: "Piece",
				column: "Id");

			migrationBuilder.AddPrimaryKey(
				name: "PK_Passwords",
				table: "Passwords",
				column: "Id");

			migrationBuilder.AddPrimaryKey(
				name: "PK_Files",
				table: "Files",
				column: "Id");

			migrationBuilder.AddPrimaryKey(
				name: "PK_FilePieces",
				table: "FilePieces",
				column: "Id");

			migrationBuilder.CreateTable(
				name: "Manufacturers",
				columns: table => new
				{
					Id = table.Column<string>(nullable: false),
					Name = table.Column<string>(nullable: true),
					VinPrefix = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Manufacturers", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Cars",
				columns: table => new
				{
					Id = table.Column<string>(nullable: false),
					ManufacturerId = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Cars", x => x.Id);
					table.ForeignKey(
						name: "FK_Cars_Manufacturers_ManufacturerId",
						column: x => x.ManufacturerId,
						principalTable: "Manufacturers",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
				});

			migrationBuilder.CreateTable(
				name: "OwnedCars",
				columns: table => new
				{
					Id = table.Column<string>(nullable: false),
					CarId = table.Column<string>(nullable: true),
					Vin = table.Column<string>(nullable: true),
					ManufacturedDate = table.Column<DateTime>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_OwnedCars", x => x.Id);
					table.ForeignKey(
						name: "FK_OwnedCars_Cars_CarId",
						column: x => x.CarId,
						principalTable: "Cars",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
				});

			migrationBuilder.CreateIndex(
				name: "IX_Cars_ManufacturerId",
				table: "Cars",
				column: "ManufacturerId");

			migrationBuilder.CreateIndex(
				name: "IX_OwnedCars_CarId",
				table: "OwnedCars",
				column: "CarId");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "OwnedCars");

			migrationBuilder.DropTable(
				name: "Cars");

			migrationBuilder.DropTable(
				name: "Manufacturers");

			migrationBuilder.DropPrimaryKey(
				name: "PK_Users",
				table: "Users");

			migrationBuilder.DropPrimaryKey(
				name: "PK_Sessions",
				table: "Sessions");

			migrationBuilder.DropPrimaryKey(
				name: "PK_PostTypes",
				table: "PostTypes");

			migrationBuilder.DropPrimaryKey(
				name: "PK_Posts",
				table: "Posts");

			migrationBuilder.DropPrimaryKey(
				name: "PK_Piece",
				table: "Piece");

			migrationBuilder.DropPrimaryKey(
				name: "PK_Passwords",
				table: "Passwords");

			migrationBuilder.DropPrimaryKey(
				name: "PK_Files",
				table: "Files");

			migrationBuilder.DropPrimaryKey(
				name: "PK_FilePieces",
				table: "FilePieces");

			migrationBuilder.RenameTable(
				name: "Users",
				newName: "users");

			migrationBuilder.RenameTable(
				name: "Sessions",
				newName: "sessions");

			migrationBuilder.RenameTable(
				name: "PostTypes",
				newName: "postTypes");

			migrationBuilder.RenameTable(
				name: "Posts",
				newName: "posts");

			migrationBuilder.RenameTable(
				name: "Piece",
				newName: "piece");

			migrationBuilder.RenameTable(
				name: "Passwords",
				newName: "passwords");

			migrationBuilder.RenameTable(
				name: "Files",
				newName: "files");

			migrationBuilder.RenameTable(
				name: "FilePieces",
				newName: "filePieces");

			migrationBuilder.AddPrimaryKey(
				name: "PK_users",
				table: "users",
				column: "Id");

			migrationBuilder.AddPrimaryKey(
				name: "PK_sessions",
				table: "sessions",
				column: "Id");

			migrationBuilder.AddPrimaryKey(
				name: "PK_postTypes",
				table: "postTypes",
				column: "Id");

			migrationBuilder.AddPrimaryKey(
				name: "PK_posts",
				table: "posts",
				column: "Id");

			migrationBuilder.AddPrimaryKey(
				name: "PK_piece",
				table: "piece",
				column: "Id");

			migrationBuilder.AddPrimaryKey(
				name: "PK_passwords",
				table: "passwords",
				column: "Id");

			migrationBuilder.AddPrimaryKey(
				name: "PK_files",
				table: "files",
				column: "Id");

			migrationBuilder.AddPrimaryKey(
				name: "PK_filePieces",
				table: "filePieces",
				column: "Id");
			
		}
	}
}
