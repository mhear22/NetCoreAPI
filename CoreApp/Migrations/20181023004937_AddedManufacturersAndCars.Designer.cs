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
    [Migration("20181023004937_AddedManufacturersAndCars")]
    partial class AddedManufacturersAndCars
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

                    b.ToTable("Files");
                });

            modelBuilder.Entity("CoreApp.Models.Repositories.FilePieceDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Hash");

                    b.Property<int>("Length");

                    b.HasKey("Id");

                    b.ToTable("Piece");
                });

            modelBuilder.Entity("CoreApp.Models.Repositories.FilePiecesDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FileId");

                    b.Property<string>("FilePieceId");

                    b.Property<int>("PieceNumber");

                    b.HasKey("Id");

                    b.ToTable("FilePieces");
                });

            modelBuilder.Entity("CoreApp.Models.Repositories.PasswordDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateSet");

                    b.Property<string>("Hash");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Passwords");
                });

            modelBuilder.Entity("CoreApp.Models.Repositories.PostDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PostTypeId");

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("CoreApp.Models.Repositories.PostTypeDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("PostTypes");
                });

            modelBuilder.Entity("CoreApp.Models.Repositories.SessionDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("SetTime");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("CoreApp.Models.Repositories.UserDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EmailAddress");

                    b.Property<string>("ImageId");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CoreApp.Models.Repositories.Vehicle.CarDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ManufacturerId");

                    b.HasKey("Id");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CoreApp.Models.Repositories.Vehicle.ManufacturerDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("VinPrefix");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("CoreApp.Models.Repositories.Vehicle.OwnedCarDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CarId");

                    b.Property<DateTime>("ManufacturedDate");

                    b.Property<string>("Vin");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("OwnedCars");
                });

            modelBuilder.Entity("CoreApp.Models.Repositories.Vehicle.CarDto", b =>
                {
                    b.HasOne("CoreApp.Models.Repositories.Vehicle.ManufacturerDto", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerId");
                });

            modelBuilder.Entity("CoreApp.Models.Repositories.Vehicle.OwnedCarDto", b =>
                {
                    b.HasOne("CoreApp.Models.Repositories.Vehicle.CarDto", "BaseModel")
                        .WithMany()
                        .HasForeignKey("CarId");
                });
#pragma warning restore 612, 618
        }
    }
}
