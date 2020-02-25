using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GRTHabitation.Migrations
{
    public partial class GRTH : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applicant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HousingTypeSought = table.Column<string>(nullable: true),
                    FamilyIncome = table.Column<double>(nullable: false),
                    HaveAnimals = table.Column<bool>(nullable: false),
                    HaveLease = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Housing",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OwnerId = table.Column<int>(nullable: false),
                    ContactId = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Sector = table.Column<string>(nullable: true),
                    SchoolArea = table.Column<string>(nullable: true),
                    RoomCount = table.Column<int>(nullable: false),
                    ParkingCount = table.Column<int>(nullable: false),
                    Level = table.Column<string>(nullable: true),
                    AllowAnimals = table.Column<bool>(nullable: false),
                    Heated = table.Column<bool>(nullable: false),
                    Enlightened = table.Column<bool>(nullable: false),
                    SemiFurnished = table.Column<bool>(nullable: false),
                    FirstRentFree = table.Column<bool>(nullable: false),
                    RentCost = table.Column<bool>(nullable: false),
                    EnergyCost = table.Column<double>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    ElectronicSignature = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Housing", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    QualificationId = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    BirthDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Qualification",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HousingId = table.Column<int>(nullable: false),
                    HaveMoldTraces = table.Column<bool>(nullable: false),
                    StairSafety = table.Column<int>(nullable: false),
                    PeronSafety = table.Column<int>(nullable: false),
                    LightningSafety = table.Column<int>(nullable: false),
                    DetectorSafety = table.Column<int>(nullable: false),
                    Cleanliness = table.Column<int>(nullable: false),
                    WindowsQuality = table.Column<int>(nullable: false),
                    DoorsQuality = table.Column<int>(nullable: false),
                    FittingsQuality = table.Column<int>(nullable: false),
                    ToiletQuality = table.Column<int>(nullable: false),
                    BathShowerQuality = table.Column<int>(nullable: false),
                    GeneralMaintenance = table.Column<int>(nullable: false),
                    PestProblem = table.Column<bool>(nullable: false),
                    FinalScore = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FolderNumber = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applicant");

            migrationBuilder.DropTable(
                name: "Housing");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "Owner");

            migrationBuilder.DropTable(
                name: "Qualification");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
