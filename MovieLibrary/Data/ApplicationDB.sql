CREATE DATABASE [MLibraryDB]
GO
USE [MLibraryDB]
GO

CREATE TABLE [Accounts]
(
	[AId] INT IDENTITY PRIMARY KEY NOT NULL,
	[FirstName] VARCHAR(50) NOT NULL,
	[LastName] VARCHAR(50) NOT NULL,
	[Username] VARCHAR(25) NOT NULL UNIQUE,
	[Password] VARCHAR(50) NOT NULL,
	[RecoveryKey] INT NOT NULL UNIQUE
);

CREATE TABLE[Genres]
(
	[GId] INT NOT NULL IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	CONSTRAINT [pk_genre_id] PRIMARY KEY([GId])
);

CREATE TABLE [Movies]
(
	[MId] INT IDENTITY NOT NULL,
	[Title] VARCHAR(100) NOT NULL,
	[GenreId] INT NOT NULL,
	[Image] IMAGE NULL,
	[YearOfCreation] INT,
	[Rate] float,
	CONSTRAINT [pk_movies_id] PRIMARY KEY([MId]),
	CONSTRAINT [fk_movies_id_genre] FOREIGN KEY([GenreId]) REFERENCES [Genres]([GId])
);

CREATE TABLE [AccountsMovies]
(
	[AccountId] INT NOT NULL,
	[MovieId] INT NOT NULL,
	[State] VARCHAR(20) NOT NULL CHECK([State] IN('Watching','Watched','Plan to watch')),
	CONSTRAINT [fk_accountsMovies_account] FOREIGN KEY ([AccountId]) REFERENCES [Accounts]([AId]),
	CONSTRAINT [fk_accountsMovies_movies] FOREIGN KEY ([MovieId]) REFERENCES [Movies]([MId])
);
