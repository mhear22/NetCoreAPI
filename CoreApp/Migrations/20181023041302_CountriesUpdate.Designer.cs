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
    [Migration("20181023041302_CountriesUpdate")]
    partial class CountriesUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CoreApp.Models.Repositories.CountryDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("VinPrefix");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0188C7F3F160", Name = "unassigned", VinPrefix = "AP-A0" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0188C7F3F161", Name = "Angola", VinPrefix = "BA-BE" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0188C7F3F162", Name = "Kenya", VinPrefix = "BF-BK" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0188C7F3F163", Name = "Tanzania", VinPrefix = "BL-BR" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0188C7F3F164", Name = "unassigned", VinPrefix = "BS-B0" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0188C7F3F165", Name = "Benin", VinPrefix = "CA-CE" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0188C7F3F166", Name = "Madagascar", VinPrefix = "CF-CK" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0188C7F3F167", Name = "Tunisia", VinPrefix = "CL-CR" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0188C7F3F168", Name = "unassigned", VinPrefix = "CS-C0" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0188C7F3F169", Name = "Egypt", VinPrefix = "DA-DE" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0188C7F3F110", Name = "Morocco", VinPrefix = "DF-DK" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-1188C7F3F520", Name = "Zambia", VinPrefix = "DL-DR" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0188C7F3F130", Name = "unassigned", VinPrefix = "DS-D0" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0188C7F3F540", Name = "Ethiopia", VinPrefix = "EA-EE" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0188C7F3F550", Name = "Mozambique", VinPrefix = "EF-EK" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0188C7F3F509", Name = "unassigned", VinPrefix = "EL-E0" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0188C7F3F508", Name = "Ghana", VinPrefix = "FA-FE" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0188C7F3F507", Name = "Nigeria", VinPrefix = "FF-FK" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0188C7F3F506", Name = "unassigned", VinPrefix = "FL-F0" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0188C7F3F505", Name = "unassigned", VinPrefix = "GA-G0" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0188C7F3F504", Name = "unassigned", VinPrefix = "HA-H0" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0188C7F3F503", Name = "Japan", VinPrefix = "J" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0188C7F3F502", Name = "Sri Lanka", VinPrefix = "KA-KE" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0188C7F3F501", Name = "Israel", VinPrefix = "KF-KK" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0188C7F3F565", Name = "Korea (South)", VinPrefix = "KL-KR" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F516", Name = "Kazakhstan", VinPrefix = "KS-K0" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", Name = "China (Mainland)", VinPrefix = "L" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F518", Name = "India", VinPrefix = "MA-ME" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F519", Name = "Indonesia", VinPrefix = "MF-MK" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F520", Name = "Thailand", VinPrefix = "ML-MR" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F521", Name = "Myanmar", VinPrefix = "MS-M0" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F522", Name = "Iran", VinPrefix = "NA-NE" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F523", Name = "Pakistan", VinPrefix = "NF-NK" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F524", Name = "Turkey", VinPrefix = "NL-NR" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F525", Name = "unassigned", VinPrefix = "NS-N0" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F526", Name = "Philippines", VinPrefix = "PA-PE" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F527", Name = "Singapore", VinPrefix = "PF-PK" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F528", Name = "Malaysia", VinPrefix = "PL-PR" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F529", Name = "unassigned", VinPrefix = "PS-P0" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F530", Name = "United Arab Emirates", VinPrefix = "RA-RE" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F531", Name = "Taiwan", VinPrefix = "RF-RK" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F532", Name = "Vietnam", VinPrefix = "RL-RR" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F533", Name = "Saudi Arabia", VinPrefix = "RS-R0" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F534", Name = "United Kingdom", VinPrefix = "SA-SM" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F535", Name = "Germany (formerly East Germany)", VinPrefix = "SN-ST" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F536", Name = "Poland", VinPrefix = "SU-SZ" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F537", Name = "Latvia", VinPrefix = "S1-S4" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F538", Name = "unassigned", VinPrefix = "S5-S0" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F539", Name = "Switzerland", VinPrefix = "TA-TH" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F540", Name = "Czech Republic", VinPrefix = "TJ-TP" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F541", Name = "Hungary", VinPrefix = "TR-TV" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F542", Name = "Portugal", VinPrefix = "TW-T1" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F543", Name = "unassigned", VinPrefix = "T2-T0" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F544", Name = "unassigned", VinPrefix = "UA-UG" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F545", Name = "Denmark", VinPrefix = "UH-UM" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F546", Name = "Ireland", VinPrefix = "UN-UT" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F547", Name = "Romania", VinPrefix = "UU-UZ" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F548", Name = "unassigned", VinPrefix = "U1-U4" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F549", Name = "Slovakia", VinPrefix = "U5-U7" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F550", Name = "unassigned", VinPrefix = "U8-U0" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F551", Name = "Austria", VinPrefix = "VA-VE" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F552", Name = "France", VinPrefix = "VF-VR" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F553", Name = "Spain", VinPrefix = "VS-VW" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F554", Name = "Serbia", VinPrefix = "VX-V2" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F555", Name = "Croatia", VinPrefix = "V3-V5" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F556", Name = "Estonia", VinPrefix = "V6-V0" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", Name = "Germany (formerly West Germany)", VinPrefix = "W" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F558", Name = "Bulgaria", VinPrefix = "XA-XE" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F559", Name = "Greece", VinPrefix = "XF-XK" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F561", Name = "Netherlands", VinPrefix = "XL-XR" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F562", Name = "Russia (former USSR)", VinPrefix = "XS-XW" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F563", Name = "Luxembourg", VinPrefix = "XX-X2" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F564", Name = "Russia", VinPrefix = "X3-X0" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F565", Name = "Belgium", VinPrefix = "YA-YE" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F566", Name = "Finland", VinPrefix = "YF-YK" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F567", Name = "Malta", VinPrefix = "YL-YR" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F568", Name = "Sweden", VinPrefix = "YS-YW" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F569", Name = "Norway", VinPrefix = "YX-Y2" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F570", Name = "Belarus", VinPrefix = "Y3-Y5" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F571", Name = "Ukraine", VinPrefix = "Y6-Y0" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F572", Name = "Italy", VinPrefix = "ZA-ZR" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F573", Name = "unassigned", VinPrefix = "ZS-ZW" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F574", Name = "Slovenia", VinPrefix = "ZX-Z2" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F575", Name = "Lithuania", VinPrefix = "Z3-Z5" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F576", Name = "unassigned", VinPrefix = "Z6-Z0" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", Name = "United States", VinPrefix = "5" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F578", Name = "United States", VinPrefix = "4" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F579", Name = "United States", VinPrefix = "1" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F580", Name = "Canada", VinPrefix = "2" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F581", Name = "Mexico", VinPrefix = "3A-3W" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F582", Name = "Costa Rica", VinPrefix = "3X-37" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F583", Name = "Cayman Islands", VinPrefix = "38-39" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F584", Name = "unassigned", VinPrefix = "30" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F585", Name = "Australia", VinPrefix = "6" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F586", Name = "New Zealand", VinPrefix = "7" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F587", Name = "Argentina", VinPrefix = "8A-8E" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F588", Name = "Chile", VinPrefix = "8F-8K" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F589", Name = "Ecuador", VinPrefix = "8L-8R" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F590", Name = "Peru", VinPrefix = "8S-8W" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F591", Name = "Venezuela", VinPrefix = "8X-82" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F592", Name = "unassigned", VinPrefix = "83-80" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F593", Name = "Brazil", VinPrefix = "9A-9E" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F594", Name = "Colombia", VinPrefix = "9F-9K" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F595", Name = "Paraguay", VinPrefix = "9L-9R" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F596", Name = "Uruguay", VinPrefix = "9S-9W" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F597", Name = "Trinidad & Tobago", VinPrefix = "9X-92" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", Name = "Brazil", VinPrefix = "93–99" },
                        new { Id = "4E8349F3-BE69-4A7E-9AC7-0588C7F3F599", Name = "unassigned", VinPrefix = "90" }
                    );
                });

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

                    b.HasData(
                        new { Id = "8b6e9487-db5b-4985-9852-ecca594d0024", Name = "Toyota", VinPrefix = "" }
                    );
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

            modelBuilder.Entity("CoreApp.Models.Repositories.Vehicle.VinVDS", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Matcher");

                    b.HasKey("Id");

                    b.ToTable("VinVDSs");
                });

            modelBuilder.Entity("CoreApp.Models.Repositories.Vehicle.VinVIS", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Matcher");

                    b.HasKey("Id");

                    b.ToTable("VinVISs");
                });

            modelBuilder.Entity("CoreApp.Models.Repositories.Vehicle.VinWMI", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CountryId");

                    b.Property<string>("ManufacturerId");

                    b.Property<string>("Matcher");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("VinWMIs");

                    b.HasData(
                        new { Id = "8b6e9487-db5b-4985-9852-ecca594d0024", CountryId = "8b6e9487-db5b-4985-9852-ecca594d0024", ManufacturerId = "8b6e9487-db5b-4985-9852-ecca594d0024", Matcher = "6T1" }
                    );
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

            modelBuilder.Entity("CoreApp.Models.Repositories.Vehicle.VinWMI", b =>
                {
                    b.HasOne("CoreApp.Models.Repositories.CountryDto", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("CoreApp.Models.Repositories.Vehicle.ManufacturerDto", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerId");
                });
#pragma warning restore 612, 618
        }
    }
}
