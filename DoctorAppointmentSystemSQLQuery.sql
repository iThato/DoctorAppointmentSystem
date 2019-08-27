CREATE DATABASE DoctorAppointmentSystem;


USE DoctorAppointmentSystem
GO

CREATE TABLE Doctor
(
	ID	int	PRIMARY KEY IDENTITY,
	DoctorName	varchar(100)	NOT NULL,
	DoctorAvalableTime Time NOT NULL
)
GO


CREATE TABLE Appointment
(
	ID	int	PRIMARY KEY IDENTITY,
	PatientFirstName varchar(100) NOT NULL,
	PatientLastName varchar(100) NOT NULL,
	Email NVARCHAR(320) NOT NULL,
	CellNumber varchar(10),
	DoctorId int FOREIGN KEY REFERENCES Doctor(ID),
	AvailableTime Time NOT NULL
	
)
GO