USE Piljetter
CREATE TABLE City
(
[Id] INT IDENTITY(1,1) NOT NULL,
[Name] NVARCHAR(50) NOT NULL,
[Country] NVARCHAR(20) NOT NULL,
PRIMARY KEY (Id)
)
CREATE TABLE Artist 
(
[Id] INT IDENTITY(1,1) NOT NULL,
[Name] NVARCHAR(20) NOT NULL,
PRIMARY KEY (Id)
)

CREATE TABLE Stage
(
[Id] INT IDENTITY(1,1) NOT NULL,
[Name] NVARCHAR(50) NOT NULL UNIQUE,
[MaxVisitors] INT NOT NULL,
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
[Stage_Id] INT FOREIGN KEY REFERENCES Stage([Id]) NOT NULL,
[Artist_Id] INT FOREIGN KEY REFERENCES Artist([Id]) NOT NULL,
PRIMARY KEY (Id)
)
ALTER TABLE Concert
ADD CONSTRAINT [Date] CHECK (
    CAST([Date] as date) >= CAST(GETDATE() as date)
     );
ALTER TABLE Concert
ADD CONSTRAINT ArtistAndTime UNIQUE ([Date], Artist_Id)

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

CREATE TABLE Ticket
(
[Id] INT IDENTITY(1,1) NOT NULL,
[Concert_Id] INT FOREIGN KEY REFERENCES Concert([Id]) NOT NULL,
[Customer_Id] INT FOREIGN KEY REFERENCES Customer([Id]) NOT NULL,
[Price] INT NOT NULL,
PRIMARY KEY ([Id])
)

CREATE TABLE TicketCupon
(
[Id] INT IDENTITY NOT NULL,
Customer_Id INT FOREIGN KEY REFERENCES Customer ([Id]) NOT NULL,
PRIMARY KEY ([Id])
)

CREATE TABLE [Admin]
(
[Id] INT IDENTITY (1,1) NOT NULL,
[Name] NVARCHAR (30) UNIQUE NOT NULL,
[Password] NVARCHAR(30) NOT NULL,
PRIMARY KEY ([Id])
)
SELECT * FROM Customer
INSERT INTO [Admin] ([Name], [Password]) VALUES ('Admin', 'abc123');
INSERT INTO [Admin] ([Name], [Password]) VALUES ('david', 'hej123');


INSERT INTO Artist ([Name]) VALUES ('Queen');
INSERT INTO Artist ([Name]) VALUES ('KISS');
INSERT INTO Artist ([Name]) VALUES ('ABBA');
INSERT INTO Artist ([Name]) VALUES ('Green Day');

INSERT INTO City ([Name], [Country]) VALUES ('Göteborg', 'Sverige');
INSERT INTO City ([Name], [Country]) VALUES ('Stockholm', 'Sverige');
INSERT INTO City ([Name], [Country]) VALUES ('London', 'England');
INSERT INTO City ([Name], [Country]) VALUES ('New York', 'USA');

INSERT INTO Stage ([City_Id], [Name], [MaxVisitors]) VALUES (1, 'Ullevi', 30000);
INSERT INTO Stage ([City_Id], [Name], [MaxVisitors]) VALUES (3, 'London Palladium', 2000);
INSERT INTO Stage ([City_Id], [Name], [MaxVisitors]) VALUES (2, 'Friends arena', 25000);
INSERT INTO Stage ([City_Id], [Name], [MaxVisitors]) VALUES (4, 'Madison Square Garden', 20000);
INSERT INTO Stage ([City_Id], [Name], [MaxVisitors]) VALUES (1, 'Sticky Fingers', 530);

INSERT INTO Concert ([Name], [Date], [City_Id], [Artist_Id], [Stage_Id]) VALUES ('Queen concert', GetDate(), 1, 1, 1);
INSERT INTO Concert ([Name], [Date], [City_Id], [Artist_Id], [Stage_Id]) VALUES ('Abba concert', GetDate(), 3, 3, 1);
INSERT INTO Concert ([Name], [Date], [City_Id], [Artist_Id], [Stage_Id]) VALUES ('Green Day concert', GetDate(), 4, 4, 1);

INSERT INTO Customer ([FirstName], [LastName], [Email], [Username], [Password], [Pesetas]) VALUES ('David', 'Larsson', 'david@gmail.com', 'Davlar', '123', 555);
INSERT INTO Customer ([FirstName], [LastName], [Email], [Username], [Password], [Pesetas]) VALUES ('Martin', 'Larsson', 'martin@gmail.com', 'M', '123', 555);
INSERT INTO Customer ([FirstName], [LastName], [Email], [Username], [Password], [Pesetas]) VALUES ('Nicklas', 'Löfstrand', 'Nicklas@gmail.com', 'Nicke', '123', 555);
INSERT INTO Customer ([FirstName], [LastName], [Email], [Username], [Password], [Pesetas]) VALUES ('Jesper', 'Larsson', 'jesper@gmail.com', 'Jeppe', '123', 555);
INSERT INTO Customer ([FirstName], [LastName], [Email], [Username], [Password], [Pesetas]) VALUES ('Johan', 'Bernhardsson', 'johan@gmail.com', 'Juan', '123', 555);

SELECT * from Concert