INSERT INTO "User"("Id", "FolderNumber", "Address", "City", "PostalCode", "Password") VALUES
(1, '1234', '3000 Boulevard de Tracy QC', 'Sorel-Tracy', 'J3R 5B9', 'Omega123'),
(2, '4321', '125 Rue du Roi QC', 'Contrecoeur', 'J3P 4N2', 'Omega123')
;

INSERT INTO "Applicant"("Id", "HousingTypeSought", "FamilyIncome", "HaveAnimals", "HaveLease") VALUES
(1, 'idk', 43123.40, true, false)
;

INSERT INTO "Member"("Id", "FirstName", "LastName", "Email", "Type", "PhoneNumber", "BirthDate", "ApplicantId") VALUES
(1, 'Bob', 'Lewis', 'boblewis@gmail.com', 'User', '4507426651', '2001-09-28', NULL),
(2, 'Alex', 'Dufour', 'alexdufour@gmail.com', 'Child', '4507426651', '2018-04-12', '1'),
(3, 'George', 'Laroque', 'georgelaroque@gmail.com', 'User', '4507413151', '2002-01-18', NULL)
;

INSERT INTO "Owner"("Id") VALUES
('0')
;

INSERT INTO "Housing"(
    "Id", "OwnerId", "ContactId", "Address", "Sector", "SchoolArea", "RoomCount", "ParkingCount", "Level", "AllowAnimals",
    "Heated", "Enlightened", "SemiFurnished", "FirstRentFree", "RentCost", "EnergyCost", "Note", "ElectronicSignature"
) VALUES
('0', '1')
;