Create database Football
USE Football
Create table Stadion(
ID INT PRIMARY KEY IDENTITY,
Name NVARCHAR(255) NOT NULL,
HourPrice INT NOT NULL,
Capacity INT NOT NULL
)
Create table Users(
ID INT PRIMARY KEY IDENTITY,
FullName NVARCHAR(255) NOT NULL,
Email NVARCHAR(255)NOT NULL
)
Create table Reservations(
ID INT PRIMARY KEY IDENTITY,
StadionID INT FOREIGN KEY REFERENCES Stadion(ID),
UserID INT FOREIGN KEY REFERENCES Users(ID),
StartDate DATETIME2 NOT NULL,
ENDDATE DATETIME2 NOT NULL

)
INSERT INTO Users VALUES('Full Name','email@email.com')
INSERT INTO Stadion VALUES ('Stadion1',100,50)
SELECT * FROM Stadion
SELECT * FROM Users
SELECT * FROM Reservations
INSERT INTO Reservations VALUES(1,1,'2022-09-09','2022-10-10') 