CREATE DATABASE Piljetter

USE Piljetter

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
PRIMARY KEY (Id)
)

CREATE TABLE City
(
[Id] INT IDENTITY(1,1) NOT NULL,
[Name] NVARCHAR(50) NOT NULL,
[Country] NVARCHAR(20) NOT NULL,
PRIMARY KEY (Id)
)

CREATE TABLE Concert
(
[Id] INT IDENTITY(1,1) NOT NULL,
[Name] NVARCHAR(20) NOT NULL,
[Date] DATETIME NOT NULL,
[Stage_Id] INT FOREIGN KEY REFERENCES Stage([Id]),
[Artist_Id] INT FOREIGN KEY REFERENCES Artist([Id]),
[City_Id] INT FOREIGN KEY REFERENCES City([Id]),
PRIMARY KEY (Id)
)

INSERT INTO Artist ([Name]) VALUES ('Queen');
INSERT INTO Artist ([Name]) VALUES ('KISS');
INSERT INTO Artist ([Name]) VALUES ('ABBA');
INSERT INTO Artist ([Name]) VALUES ('Green Day');

INSERT INTO City ([Name], [Country]) VALUES ('Göteborg', 'Sverige');
INSERT INTO City ([Name], [Country]) VALUES ('Stockholm', 'Sverige');
INSERT INTO City ([Name], [Country]) VALUES ('London', 'England');
INSERT INTO City ([Name], [Country]) VALUES ('New York', 'USA');

INSERT INTO Stage ([Name], [MaxVisitors]) VALUES ('Ullevi', 30000);
INSERT INTO Stage ([Name], [MaxVisitors]) VALUES ('London Palladium', 2000);
INSERT INTO Stage ([Name], [MaxVisitors]) VALUES ('Friends arena', 25000);
INSERT INTO Stage ([Name], [MaxVisitors]) VALUES ('Madison Square Garden', 20000);
INSERT INTO Stage ([Name], [MaxVisitors]) VALUES ('Sticky Fingers', 530);

INSERT INTO Concert ([Name], [Date], [City_Id], [Artist_Id], [Stage_Id]) VALUES ('Queen concert', GetDate(), 1, 1, 1);
INSERT INTO Concert ([Name], [Date], [City_Id], [Artist_Id], [Stage_Id]) VALUES ('Abba concert', GetDate(), 3, 3, 1);
INSERT INTO Concert ([Name], [Date], [City_Id], [Artist_Id], [Stage_Id]) VALUES ('Green Day concert', GetDate(), 4, 4, 1);
