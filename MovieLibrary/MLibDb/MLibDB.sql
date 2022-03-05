﻿CREATE DATABASE MLibDB
GO
USE MLibDB
GO

USE MLibDB

CREATE TABLE Accounts
(
	Id INT IDENTITY PRIMARY KEY,
	Username VARCHAR(25) NOT NULL,
	Password VARCHAR(50) NOT NULL,
	RecoveryKey INT NOT NULL,
	BirthDate DATE NOT NULL
);

INSERT INTO Accounts(Username,Password,RecoveryKey,BirthDate)
VALUES('Admin','Admin',123456,'2004-10-28');
