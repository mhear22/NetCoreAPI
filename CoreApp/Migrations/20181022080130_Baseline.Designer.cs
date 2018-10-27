﻿// <auto-generated />
using System;
using CoreApp.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreApp.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20181022080130_Baseline")]
    partial class Baseline
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CoreApp.Models.Repositories.FileDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Filename");

                    b.Property<int>("Length");

                    b.HasKey("Id");

                    b.ToTable("files");
                });

            modelBuilder.Entity("CoreApp.Models.Repositories.FilePieceDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Hash");

                    b.Property<int>("Length");

                    b.HasKey("Id");

                    b.ToTable("piece");
                });

            modelBuilder.Entity("CoreApp.Models.Repositories.FilePiecesDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FileId");

                    b.Property<string>("FilePieceId");

                    b.Property<int>("PieceNumber");

                    b.HasKey("Id");

                    b.ToTable("filePieces");
                });

            modelBuilder.Entity("CoreApp.Models.Repositories.PasswordDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateSet");

                    b.Property<string>("Hash");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("passwords");
                });

            modelBuilder.Entity("CoreApp.Models.Repositories.PostDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PostTypeId");

                    b.HasKey("Id");

                    b.ToTable("posts");
                });

            modelBuilder.Entity("CoreApp.Models.Repositories.PostTypeDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("postTypes");
                });

            modelBuilder.Entity("CoreApp.Models.Repositories.SessionDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("SetTime");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("sessions");
                });

            modelBuilder.Entity("CoreApp.Models.Repositories.UserDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EmailAddress");

                    b.Property<string>("ImageId");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}