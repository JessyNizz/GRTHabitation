﻿// <auto-generated />
using GRTHabitation.Models.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GRTHabitation.Migrations
{
    [DbContext(typeof(GRTHDbContext))]
    partial class GRTHDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("GRTHabitation.Models.Database.EntityObjects.Applicant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("FamilyIncome")
                        .HasColumnType("double precision");

                    b.Property<bool>("HaveAnimals")
                        .HasColumnType("boolean");

                    b.Property<bool>("HaveLease")
                        .HasColumnType("boolean");

                    b.Property<string>("HousingTypeSought")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Applicant");
                });

            modelBuilder.Entity("GRTHabitation.Models.Database.EntityObjects.Housing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<bool>("AllowAnimals")
                        .HasColumnType("boolean");

                    b.Property<int>("ContactId")
                        .HasColumnType("integer");

                    b.Property<string>("ElectronicSignature")
                        .HasColumnType("text");

                    b.Property<double>("EnergyCost")
                        .HasColumnType("double precision");

                    b.Property<bool>("Enlightened")
                        .HasColumnType("boolean");

                    b.Property<bool>("FirstRentFree")
                        .HasColumnType("boolean");

                    b.Property<bool>("Heated")
                        .HasColumnType("boolean");

                    b.Property<string>("Level")
                        .HasColumnType("text");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<int>("OwnerId")
                        .HasColumnType("integer");

                    b.Property<int>("ParkingCount")
                        .HasColumnType("integer");

                    b.Property<bool>("RentCost")
                        .HasColumnType("boolean");

                    b.Property<int>("RoomCount")
                        .HasColumnType("integer");

                    b.Property<string>("SchoolArea")
                        .HasColumnType("text");

                    b.Property<string>("Sector")
                        .HasColumnType("text");

                    b.Property<bool>("SemiFurnished")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Housing");
                });

            modelBuilder.Entity("GRTHabitation.Models.Database.EntityObjects.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<string>("Path")
                        .HasColumnType("text");

                    b.Property<int>("QualificationId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("GRTHabitation.Models.Database.EntityObjects.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("BirthDate")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("GRTHabitation.Models.Database.EntityObjects.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.HasKey("Id");

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("GRTHabitation.Models.Database.EntityObjects.Qualification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BathShowerQuality")
                        .HasColumnType("integer");

                    b.Property<int>("Cleanliness")
                        .HasColumnType("integer");

                    b.Property<int>("DetectorSafety")
                        .HasColumnType("integer");

                    b.Property<int>("DoorsQuality")
                        .HasColumnType("integer");

                    b.Property<int>("FinalScore")
                        .HasColumnType("integer");

                    b.Property<int>("FittingsQuality")
                        .HasColumnType("integer");

                    b.Property<int>("GeneralMaintenance")
                        .HasColumnType("integer");

                    b.Property<bool>("HaveMoldTraces")
                        .HasColumnType("boolean");

                    b.Property<int>("HousingId")
                        .HasColumnType("integer");

                    b.Property<int>("LightningSafety")
                        .HasColumnType("integer");

                    b.Property<int>("PeronSafety")
                        .HasColumnType("integer");

                    b.Property<bool>("PestProblem")
                        .HasColumnType("boolean");

                    b.Property<int>("StairSafety")
                        .HasColumnType("integer");

                    b.Property<int>("ToiletQuality")
                        .HasColumnType("integer");

                    b.Property<int>("WindowsQuality")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Qualification");
                });

            modelBuilder.Entity("GRTHabitation.Models.Database.EntityObjects.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<int>("FolderNumber")
                        .HasColumnType("integer");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("PostalCode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
