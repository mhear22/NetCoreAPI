using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreApp.Migrations
{
    public partial class Baseline : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "filePieces",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    FilePieceId = table.Column<string>(nullable: true),
                    FileId = table.Column<string>(nullable: true),
                    PieceNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filePieces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "files",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Length = table.Column<int>(nullable: false),
                    Filename = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_files", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "passwords",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    Hash = table.Column<string>(nullable: true),
                    DateSet = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_passwords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "piece",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Length = table.Column<int>(nullable: false),
                    Hash = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_piece", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "posts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    PostTypeId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "postTypes",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_postTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sessions",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    SetTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sessions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    ImageId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "filePieces");

            migrationBuilder.DropTable(
                name: "files");

            migrationBuilder.DropTable(
                name: "passwords");

            migrationBuilder.DropTable(
                name: "piece");

            migrationBuilder.DropTable(
                name: "posts");

            migrationBuilder.DropTable(
                name: "postTypes");

            migrationBuilder.DropTable(
                name: "sessions");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
