CREATE DATABASE MLibraryDB
GO
 USE MLibraryDB
 GO

 CREATE TABLE Accounts
 (
	Id INT IDENTITY PRIMARY KEY,
	Username VARCHAR(25) NOT NULL,
	Password VARCHAR(50) NOT NULL,
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	RecoveryKey INT NOT NULL
 );

CREATE TABLE Films
(
	Id INT IDENTITY PRIMARY KEY,
	FilmTitle VARCHAR(50) NOT NULL,
	Publisher VARCHAR(50) NOT NULL,
	FilmYear INT NOT NULL,
	FilmType VARCHAR(50) NOT NULL,
	StarsForFilms INT NOT NULL,
	RateForFilms DECIMAL NOT NULL
);

 CREATE TABLE Series
(
	Id INT IDENTITY PRIMARY KEY,
	SeriesTitle VARCHAR(50) NOT NULL,
	Seasons INT NOT NULL,
	SeriesYear INT NOT NULL,
	SeriesType VARCHAR(50) NOT NULL,
	StarsForSeries INT NOT NULL,
	RateForSeries DECIMAL NOT NULL
);

 INSERT INTO Accounts
 VALUES('Admin','Admin','Konstantin', 'Balabanov',123456);

 INSERT INTO Films
 VALUES('Encanto', 'USA','2021','Animation',5,7.3);

 INSERT INTO Series
 VALUES('Castle',8,'2009','Criminal',5,8.2);
