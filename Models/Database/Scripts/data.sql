INSERT INTO "Member"("FirstName", "LastName", "Email", "Type", "PhoneNumber", "BirthDate") VALUES
('Bryan', 'Gasse', 'bryan@fake.com', 'User', '4507431234', '2000-01-01'),
('Dave', 'Beauchesne', 'dave@fake.com', 'User', '4507421234', '1980-01-02'),
('Charles', 'Bres', 'charles@fake.com', 'User', '4508801234', '1998-03-02'),
('Marc', 'Doyon', null, 'Child', null, '2003-01-01'),
('John', 'Deschenes', 'john@fake.com','Partner', '4505170001', '1957-04-05'),
('Simon', 'Dufault', 'simon@fake.com', 'Partner', '4508811234', '1999-02-04')
;

INSERT INTO "User" ("Id", "FolderNumber", "Address", "City", "PostalCode", "Password") VALUES 
(1, 1234, '1234 Victoria', 'Sorel-Tracy', 'J3P1W3', 'Etudiant1'),
(2, 1235, '1235 Victoria', 'Sorel-Tracy', 'J3P1W3', 'Etudiant1'),
(3, 1236, '1236 Victoria', 'Sorel-Tracy', 'J3P1W3', 'Etudiant1')
;

INSERT INTO "Applicant" ("Id", "HousingTypeSought", "FamilyIncome", "HaveAnimals", "HaveLease") VALUES 
(2, '5.5', 80000, false, false),
(3, '3.5', 50000, true, false)
;

INSERT INTO "Owner" ("Id") VALUES 
(1)
;

INSERT INTO "Family" ("MemberId", "ApplicantId") VALUES 
(4, 2),
(5, 2),
(6, 3)
;

INSERT INTO "Housing" ("OwnerId", "ContactId", "Address", "Sector", "SchoolArea", "RoomCount", "ParkingCount", "Level", "AllowAnimals", "Heated", "Enlightened", "SemiFurnished", "FirstRentFree", "RentCost", "EnergyCost", "Note", "ElectronicSignature") VALUES 
(1, 1, '1234 Marie-Victorin', 'Maritime', 'Ptite ecole', 5.5, 2, 1, true, false, false, false, false, 600, 200, '', 'Bryan Gasse')
;

INSERT INTO "Qualification" ("HousingId", "HaveMoldTraces", "StairSafety", "PeronSafety", "LightningSafety", "DetectorSafety", "Cleanliness", "WindowsQuality", "DoorsQuality", "FittingsQuality", "ToiletQuality", "BathShowerQuality", "GeneralMaintenance", "PestProblem", "FinalScore") VALUES 
(1, false, '5', '4', '5', '4', '5', '3', '3', '4', '4', '4', '5', false, 46)
;