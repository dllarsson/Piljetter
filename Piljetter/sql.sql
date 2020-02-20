USE Hej
DROP DATABASE Piljetter
CREATE DATABASE Piljetter
Use Piljetter
CREATE TABLE City
(
[Id] INT IDENTITY(1,1) NOT NULL,
[Name] NVARCHAR(50) UNIQUE NOT NULL,
[Country] NVARCHAR(20) NOT NULL,
PRIMARY KEY (Id)
)
CREATE TABLE Artist 
(
[Id] INT IDENTITY(1,1) NOT NULL,
[Name] NVARCHAR(20) NOT NULL,
[Popularity] INT NOT NULL,
CHECK (Popularity >= 1 AND Popularity <= 5),
PRIMARY KEY (Id)
)



CREATE TABLE Stage
(
[Id] INT IDENTITY(1,1) NOT NULL,
[Name] NVARCHAR(50) NOT NULL UNIQUE,
[MaxVisitors] INT NOT NULL,
[StageQuality] INT NOT NULL,
[City_Id] INT FOREIGN KEY REFERENCES City([Id]) NOT NULL,
PRIMARY KEY (Id)
)
CREATE TABLE Concert
(
[Id] INT IDENTITY(1,1) NOT NULL,
[Name] NVARCHAR(20) NOT NULL,
[Date] DATETIME NOT NULL,
[IsCanceled] BIT NOT NULL DEFAULT(0),
[Pesetas] INT NOT NULL,
AvaibleTickets INT NOT NULL,
[Stage_Id] INT FOREIGN KEY REFERENCES Stage([Id]) NOT NULL,
[Artist_Id] INT FOREIGN KEY REFERENCES Artist([Id]) NOT NULL,
PRIMARY KEY (Id)
)
ALTER TABLE Concert
ADD CONSTRAINT [Date] CHECK (
    CAST([Date] as date) >= CAST(GETDATE() as date)
     );
ALTER TABLE Concert
ADD CONSTRAINT ArtistAndTime UNIQUE ([Date], Artist_Id);

ALTER TABLE Concert 
ADD CONSTRAINT StageAndTime UNIQUE ([Date], Stage_Id);

CREATE TABLE Customer
(
[Id] INT IDENTITY(1,1) NOT NULL,
[FirstName] NVARCHAR(20) NOT NULL,
[LastName] NVARCHAR(20) NOT NULL,
[Email] NVARCHAR(50) NOT NULL,
[Username] NVARCHAR(50) NOT NULL,
[Password] NVARCHAR(50) NOT NULL,
[Pesetas] INT NOT NULL DEFAULT(0),
[CreatedOnDate] DATETIME DEFAULT(GetUTCDate()),
PRIMARY KEY ([Id])
)
ALTER TABLE Customer
ADD CONSTRAINT Pesetas CHECK (Pesetas > 0);

CREATE TABLE Ticket
(
[Id] INT IDENTITY(1,1) NOT NULL,
[Concert_Id] INT FOREIGN KEY REFERENCES Concert([Id]) NOT NULL,
[Customer_Id] INT FOREIGN KEY REFERENCES Customer([Id]) NOT NULL,
[Price] INT NOT NULL,
PRIMARY KEY ([Id])
)

CREATE TABLE TicketCoupon
(
[Id] INT IDENTITY NOT NULL,
Customer_Id INT FOREIGN KEY REFERENCES Customer ([Id]) NOT NULL,
Concert_Id INT FOREIGN KEY REFERENCES Concert ([Id]),
ExpiryDate DATE NOT NULL,
PRIMARY KEY ([Id])
)

INSERT INTO Artist ([Name], Popularity) VALUES ('Queen', 4);
INSERT INTO Artist ([Name], Popularity) VALUES ('KISS', 2);
INSERT INTO Artist ([Name], Popularity) VALUES ('ABBA',5);
INSERT INTO Artist ([Name], Popularity) VALUES ('Green Day',1);
INSERT INTO Artist ([Name], Popularity) VALUES ('21 pilots',5);
INSERT INTO Artist ([Name], Popularity) VALUES ('Blink 182',5);

INSERT INTO City ([Name], [Country]) VALUES ('Göteborg', 'Sverige');
INSERT INTO City ([Name], [Country]) VALUES ('Stockholm', 'Sverige');
INSERT INTO City ([Name], [Country]) VALUES ('London', 'England');
INSERT INTO City ([Name], [Country]) VALUES ('New York', 'USA');

INSERT INTO Stage ([City_Id], [Name], [MaxVisitors], StageQuality) VALUES (1, 'Ullevi', 30000, 2);
INSERT INTO Stage ([City_Id], [Name], [MaxVisitors], StageQuality) VALUES (3, 'London Palladium', 2000,5);
INSERT INTO Stage ([City_Id], [Name], [MaxVisitors], StageQuality) VALUES (2, 'Friends arena', 25000,2);
INSERT INTO Stage ([City_Id], [Name], [MaxVisitors], StageQuality) VALUES (4, 'Madison Square Garden', 20000,3);
INSERT INTO Stage ([City_Id], [Name], [MaxVisitors], StageQuality) VALUES (1, 'Sticky Fingers', 530,1);

INSERT INTO Stage ([City_Id], [Name], [MaxVisitors], StageQuality) VALUES (1, 'Scandinavium', 26000,2);
INSERT INTO Stage ([City_Id], [Name], [MaxVisitors], StageQuality) VALUES (3, 'Some london arena', 660,4);
INSERT INTO Stage ([City_Id], [Name], [MaxVisitors], StageQuality) VALUES (2, 'Globen', 66641,1);
INSERT INTO Stage ([City_Id], [Name], [MaxVisitors], StageQuality) VALUES (4, 'Times square', 23458,5);
INSERT INTO Stage ([City_Id], [Name], [MaxVisitors], StageQuality) VALUES (1, 'Trädgårn', 1111,3);

INSERT INTO Customer ([FirstName], [LastName], [Email], [Username], [Password], [Pesetas]) VALUES ('David', 'Larsson', 'david@gmail.com', 'Davlar', '123', 10000);
INSERT INTO Customer ([FirstName], [LastName], [Email], [Username], [Password], [Pesetas]) VALUES ('Martin', 'Larsson', 'martin@gmail.com', 'M', '123', 10000);
INSERT INTO Customer ([FirstName], [LastName], [Email], [Username], [Password], [Pesetas]) VALUES ('Nicklas', 'Löfstrand', 'Nicklas@gmail.com', 'Nicke', '123', 10000);
INSERT INTO Customer ([FirstName], [LastName], [Email], [Username], [Password], [Pesetas]) VALUES ('Jesper', 'Larsson', 'jesper@gmail.com', 'Jeppe', '123', 10000);
INSERT INTO Customer ([FirstName], [LastName], [Email], [Username], [Password], [Pesetas]) VALUES ('Johan', 'Bernhardsson', 'johan@gmail.com', 'Juan', '123', 10000);

INSERT INTO Concert ([Name], [Artist_Id], [Date], [Pesetas], [Stage_Id], AvaibleTickets) VALUES ('Green day concert', 4, Convert(varchar(10), GETDATE(),120) , 300, 3,11);
INSERT INTO Concert ([Name], [Artist_Id], [Date], [Pesetas], [Stage_Id], AvaibleTickets) VALUES ('Abba concert', 3, Convert(varchar(10), GETDATE(),120) , 300, 1,33);
INSERT INTO Concert ([Name], [Artist_Id], [Date], [Pesetas], [Stage_Id], AvaibleTickets) VALUES ('Kiss concert!', 2, Convert(varchar(10), GETDATE(),120) , 300, 2,55);
INSERT INTO Concert ([Name], [Artist_Id], [Date], [Pesetas], [Stage_Id], AvaibleTickets) VALUES ('Queen concert', 1, Convert(varchar(10), GETDATE(),120) , 300, 4,9);


SelECT * FROM Concert

SELECT * FROM Ticket

SELECT * FROM TicketCoupon

SELECT Pesetas FROM Customer

SELECT t.*, c.IsCanceled AS Canceled, cu.FirstName AS Name
FROM Ticket t
INNER JOIN Concert c ON c.Id = t.Concert_Id 
INNER JOIN Customer cu ON cu.Id = t.Customer_Id
GO
CREATE TRIGGER TriggerRollback
ON Ticket
FOR INSERT
AS 
IF NOT EXISTS 
	(
		SELECT t.*
		FROM Ticket t
		INNER JOIN inserted i ON i.Id = t.Id
		WHERE t.Concert_Id = i.Concert_Id AND t.Customer_Id = i.Customer_Id
	)
BEGIN 
	RAISERROR('Concert is canceled!', 10, 1);
	ROLLBACK
END



--SELECT TriggerRollback