DROP DATABASE IF EXISTS GRTH;
CREATE DATABASE GRTH;

DROP TABLE IF EXISTS Member;

CREATE TABLE "User" (
    "Id" SERIAL PRIMARY KEY,
    "FolderNumber" INTEGER NOT NULL,
    "Address" CHAR(100) NOT NULL,    
    "City" CHAR(50) NOT NULL,
    "PostalCode" CHAR(6),
    "Password" CHAR(20)
);
 
CREATE TABLE "Applicant" (
    "Id" SERIAL PRIMARY KEY,
    "HousingTypeSought" CHAR(50),
    "FamilyIncome" DOUBLE PRECISION,
    "HaveAnimals" BOOLEAN,
    "HaveLease" BOOLEAN
);

CREATE TABLE "Member" (
    "Id" INTEGER NOT NULL REFERENCES "User"("Id") PRIMARY KEY,
    "FirstName" CHAR(50) NOT NULL,
    "LastName" CHAR(50) NOT NULL,
    "Email" CHAR(50) NULL,
    "Type" PG_ENUM("Child", "Partner", "Member") NOT NULL,
    "PhoneNumber" CHAR(20) NOT NULL,    
    "BirthDate" DATE NOT NULL,
    "ApplicantId" INTEGER NOT NULL REFERENCES "Applicant"("Id")
);

CREATE TABLE "Owner" (
    "Id" SERIAL PRIMARY KEY    
);

CREATE TABLE "Housing" (
    "Id" SERIAL PRIMARY KEY,
    "OwnerId" INTEGER NOT NULL REFERENCES "Owner"("Id"),
    "ContactId" INTEGER NOT NULL REFERENCES "Member"("Id"),
    "Address" CHAR(100) NOT NULL,
    "Sector" CHAR(50) NOT NULL,
    "SchoolArea" CHAR(50),
    "RoomCount" SMALLINT NOT NULL,
    "ParkingCount" SMALLINT DEFAULT 0,
    "Level" CHAR(10) NULL,
    "AllowAnimals" BOOLEAN DEFAULT TRUE,
    "Heated" BOOLEAN DEFAULT FALSE,
    "Enlightened" BOOLEAN DEFAULT FALSE,    
    "SemiFurnished" BOOLEAN DEFAULT FALSE,
    "FirstRentFree" BOOLEAN DEFAULT FALSE,
    "RentCost" DOUBLE PRECISION NOT NULL,
    "EnergyCost" DOUBLE PRECISION NOT NULL,
    "Note" CHAR(254),
    "ElectronicSignature" CHAR(50)    
);

CREATE TABLE "Twinning" (
    "IdApplicant" INTEGER,
    "IdHousing" INTEGER,
    PRIMARY KEY ("IdApplicant", "IdHousing"),
    FOREIGN KEY ("IdHousing") REFERENCES "Housing"("Id"),          
    FOREIGN KEY ("IdApplicant") REFERENCES "Applicant"("Id")          
);

CREATE TABLE "Qualification" (
    "Id" SERIAL PRIMARY KEY,
    "HousingId" INTEGER NOT NULL REFERENCES "Housing"("Id"),
    "HaveMoldTraces" BOOLEAN NOT NULL DEFAULT FALSE,
    "StairSafety" pg_enum(1, 2, 3, 4, 5) NOT NULL,
    "PeronSafety" pg_enum(1, 2, 3, 4, 5) NOT NULL,
    "LightningSafety" pg_enum(1, 2, 3, 4, 5) NOT NULL,
    "DetectorSafety" pg_enum(1, 2, 3, 4, 5) NOT NULL,
    "Cleanliness" pg_enum(1, 2, 3, 4, 5) NOT NULL,
    "WindowsQuality" pg_enum(1, 2, 3, 4, 5) NOT NULL,
    "DoorsQuality" pg_enum(1, 2, 3, 4, 5) NOT NULL,
    "FittingsQuality" pg_enum(1, 2, 3, 4, 5) NOT NULL,
    "ToiletQuality" pg_enum(1, 2, 3, 4, 5) NOT NULL,
    "BathShowerQuality" pg_enum(1, 2, 3, 4, 5) NOT NULL,
    "GeneralMaintenance" pg_enum(1, 2, 3, 4, 5) NOT NULL,
    "PestProblem" BOOLEAN NOT NULL DEFAULT FALSE,
    "FinalScore" SMALLINT
);

CREATE TABLE "Image" (
    "Id" SERIAL PRIMARY KEY,
    "QualificationId" INTEGER NOT NULL REFERENCES "Qualification"("Id"),
    "Note" CHAR(50) NULL,
    "Path" CHAR(254) NOT NULL
);