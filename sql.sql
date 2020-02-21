
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
[Name] NVARCHAR(20) NOT NULL UNIQUE,
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
ADD CONSTRAINT ArtistAndTime UNIQUE ([Date], Artist_Id);  --Man kan ej boka artist samma dag två gånger

ALTER TABLE Concert 
ADD CONSTRAINT StageAndTime UNIQUE ([Date], Stage_Id); -- Man kan ej boka samma scen två gånger på samma dag

CREATE TABLE Customer
(
[Id] INT IDENTITY(1,1) NOT NULL,
[FirstName] NVARCHAR(20) NOT NULL,
[LastName] NVARCHAR(20) NOT NULL,
[Username] NVARCHAR(50) NOT NULL,
[Password] NVARCHAR(50) NOT NULL,
[Pesetas] INT NOT NULL DEFAULT(0),
[CreatedOnDate] DATETIME DEFAULT(GetUTCDate()), --Databasservern och klienterna befinner sig i samma tidszon
PRIMARY KEY ([Id])
)
ALTER TABLE Customer
ADD CONSTRAINT Pesetas CHECK (Pesetas > 0);

CREATE TABLE Ticket
(
[Id] INT IDENTITY(1,1) NOT NULL,
[TimeBought] DATE NOT NULL DEFAULT (GETUTCDate()), --Databasservern och klienterna befinner sig i samma tidszon
[Concert_Id] INT FOREIGN KEY REFERENCES Concert([Id]) NOT NULL,
[Customer_Id] INT FOREIGN KEY REFERENCES Customer([Id]) NOT NULL,
[Price] INT NULL,
PRIMARY KEY ([Id])
)

ALTER TABLE Concert
ADD CONSTRAINT AvaibleTickets CHECK (
    AvaibleTickets >= 0
     );

CREATE TABLE TicketCoupon
(
[Id] INT IDENTITY NOT NULL,
Customer_Id INT FOREIGN KEY REFERENCES Customer ([Id]) NOT NULL,
Concert_Id INT FOREIGN KEY REFERENCES Concert ([Id])NOT NULL,
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

INSERT INTO Customer ([FirstName], [LastName], [Username], [Password], [Pesetas]) VALUES ('David', 'Larsson', 'Davlar', '123', 10000);
INSERT INTO Customer ([FirstName], [LastName], [Username], [Password], [Pesetas]) VALUES ('Martin', 'Larsson',  'M', '123', 10000);
INSERT INTO Customer ([FirstName], [LastName], [Username], [Password], [Pesetas]) VALUES ('Nicklas', 'Löfstrand', 'Nicke', '123', 10000);
INSERT INTO Customer ([FirstName], [LastName], [Username], [Password], [Pesetas]) VALUES ('Jesper', 'Larsson', 'Jeppe', '123', 10000);
INSERT INTO Customer ([FirstName], [LastName], [Username], [Password], [Pesetas]) VALUES ('Johan', 'Bernhardsson', 'Juan', '123', 10000);

INSERT INTO Concert ([Name], [Artist_Id], [Date], [Pesetas], [Stage_Id], AvaibleTickets) VALUES ('Green day concert', 4, GETDATE() , 23, 3, (SELECT MaxVisitors FROM Stage WHERE Id = 3));
INSERT INTO Concert ([Name], [Artist_Id], [Date], [Pesetas], [Stage_Id], AvaibleTickets) VALUES ('Abba concert', 3,GETDATE(), 66, 1,(SELECT MaxVisitors FROM Stage WHERE Id = 1));
INSERT INTO Concert ([Name], [Artist_Id], [Date], [Pesetas], [Stage_Id], AvaibleTickets) VALUES ('Kiss concert!', 2, GETDATE() , 88, 2,(SELECT MaxVisitors FROM Stage WHERE Id = 2));
INSERT INTO Concert ([Name], [Artist_Id], [Date], [Pesetas], [Stage_Id], AvaibleTickets) VALUES ('Queen concert', 1,  GETDATE() , 111, 4,(SELECT MaxVisitors FROM Stage WHERE Id = 4));

INSERT INTO Concert (Name, Date, Artist_Id, Pesetas, Stage_Id, AvaibleTickets)
SELECT c.Name, DATEADD(DAY, 11, c.Date), Artist_Id, c.Pesetas, c.Stage_Id, c.AvaibleTickets
FROM Concert c

INSERT INTO Concert (Name, Date, Artist_Id, Pesetas, Stage_Id, AvaibleTickets)
SELECT c.Name, DATEADD(DAY, 22, c.Date), Artist_Id, c.Pesetas, c.Stage_Id, c.AvaibleTickets
FROM Concert c

INSERT INTO Concert (Name, Date, Artist_Id, Pesetas, Stage_Id, AvaibleTickets)
SELECT c.Name, DATEADD(DAY, 55, c.Date), Artist_Id, c.Pesetas, c.Stage_Id, c.AvaibleTickets
FROM Concert c
INSERT INTO Concert (Name, Date, Artist_Id, Pesetas, Stage_Id, AvaibleTickets)
SELECT c.Name, DATEADD(DAY, 111, c.Date), Artist_Id, c.Pesetas, c.Stage_Id, c.AvaibleTickets
FROM Concert c
INSERT INTO Concert (Name, Date, Artist_Id, Pesetas, Stage_Id, AvaibleTickets)
SELECT c.Name, DATEADD(DAY, 222, c.Date), Artist_Id, c.Pesetas, c.Stage_Id, c.AvaibleTickets
FROM Concert c
INSERT INTO Concert (Name, Date, Artist_Id, Pesetas, Stage_Id, AvaibleTickets)
SELECT c.Name, DATEADD(DAY, 444, c.Date), Artist_Id, c.Pesetas, c.Stage_Id, c.AvaibleTickets
FROM Concert c
INSERT INTO Concert (Name, Date, Artist_Id, Pesetas, Stage_Id, AvaibleTickets)
SELECT c.Name, DATEADD(DAY, 667, c.Date), Artist_Id, c.Pesetas, c.Stage_Id, c.AvaibleTickets
FROM Concert c
INSERT INTO Concert (Name, Date, Artist_Id, Pesetas, Stage_Id, AvaibleTickets)
SELECT c.Name, DATEADD(DAY, 1500, c.Date), Artist_Id, c.Pesetas, c.Stage_Id, c.AvaibleTickets
FROM Concert c
INSERT INTO Concert (Name, Date, Artist_Id, Pesetas, Stage_Id, AvaibleTickets)
SELECT c.Name, DATEADD(DAY, 3000, c.Date), Artist_Id, c.Pesetas, c.Stage_Id, c.AvaibleTickets
FROM Concert c
INSERT INTO Concert (Name, Date, Artist_Id, Pesetas, Stage_Id, AvaibleTickets)
SELECT c.Name, DATEADD(DAY, 6000, c.Date), Artist_Id, c.Pesetas, c.Stage_Id, c.AvaibleTickets
FROM Concert c
INSERT INTO Concert (Name, Date, Artist_Id, Pesetas, Stage_Id, AvaibleTickets)
SELECT c.Name, DATEADD(DAY, 12000, c.Date), Artist_Id, c.Pesetas, c.Stage_Id, c.AvaibleTickets
FROM Concert c
INSERT INTO Concert (Name, Date, Artist_Id, Pesetas, Stage_Id, AvaibleTickets)
SELECT c.Name, DATEADD(DAY, 24000, c.Date), Artist_Id, c.Pesetas, c.Stage_Id, c.AvaibleTickets
FROM Concert c
INSERT INTO Concert (Name, Date, Artist_Id, Pesetas, Stage_Id, AvaibleTickets)
SELECT c.Name, DATEADD(DAY, 48000, c.Date), Artist_Id, c.Pesetas, c.Stage_Id, c.AvaibleTickets
FROM Concert c
INSERT INTO Concert (Name, Date, Artist_Id, Pesetas, Stage_Id, AvaibleTickets)
SELECT c.Name, DATEADD(DAY, 100000, c.Date), Artist_Id, c.Pesetas, c.Stage_Id, c.AvaibleTickets
FROM Concert c
INSERT INTO Concert (Name, Date, Artist_Id, Pesetas, Stage_Id, AvaibleTickets)
SELECT c.Name, DATEADD(DAY, 200000, c.Date), Artist_Id, c.Pesetas, c.Stage_Id, c.AvaibleTickets
FROM Concert c
INSERT INTO Concert (Name, Date, Artist_Id, Pesetas, Stage_Id, AvaibleTickets)
SELECT c.Name, DATEADD(DAY, 400000, c.Date), Artist_Id, c.Pesetas, c.Stage_Id, c.AvaibleTickets
FROM Concert c
INSERT INTO Concert (Name, Date, Artist_Id, Pesetas, Stage_Id, AvaibleTickets)
SELECT c.Name, DATEADD(DAY, 800000, c.Date), Artist_Id, c.Pesetas, c.Stage_Id, c.AvaibleTickets
FROM Concert c;




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
END;



CREATE VIEW searchResultConcert
WITH SCHEMABINDING
AS 
SELECT
c.Name, c.Artist_Id, c.Pesetas, c.AvaibleTickets, c.Id as Id, a.Name AS ArtistName, cty.Name as Cityname, s.Name AS StageName, c.Date as Date
FROM dbo.Concert c
INNER JOIN dbo.Artist a ON (a.Id = c.Artist_Id)
INNER JOIN dbo.Stage s ON (s.Id = c.Stage_Id)
INNER JOIN dbo.City cty ON (cty.Id = s.City_Id);

CREATE UNIQUE CLUSTERED INDEX ucidx_ConcertId
ON dbo.searchResultConcert(Id);

CREATE NONCLUSTERED INDEX ucidx_ArtistName
ON dbo.searchResultConcert(ArtistName);
CREATE NONCLUSTERED INDEX ucidx_StageName
ON dbo.searchResultConcert(StageName);
CREATE NONCLUSTERED INDEX ucidx_CityName
ON dbo.searchResultConcert(Cityname);
CREATE NONCLUSTERED INDEX ucidx_Date
ON dbo.searchResultConcert(Date);

