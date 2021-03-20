CREATE DATABASE OrchtechDb

USE [OrchtechDb]
GO

CREATE TABLE Gender (
    Id int,
    Name varchar(255),
	    CONSTRAINT PK_Gender PRIMARY KEY (Id)
);

CREATE TABLE Student (
    Id uniqueIdentifier,
    FirstName varchar(255),
    SecondName varchar(255),
    Mobile varchar(50),
    GenderId int,
	CONSTRAINT PK_Student PRIMARY KEY (Id),
	CONSTRAINT FK_Student_Gender FOREIGN KEY (GenderId)
        REFERENCES Gender(Id),
);

CREATE TABLE Class (
    Id uniqueIdentifier,
    Name varchar(255),
    Capacity int,
    AcceptedGenderId int,
	 CONSTRAINT PK_Class PRIMARY KEY (Id),
	 CONSTRAINT FK_Class_Gender FOREIGN KEY (AcceptedGenderId)
         REFERENCES Gender(Id),
);

create Table Enrolment(
   Id uniqueIdentifier,
   ClassId uniqueIdentifier,
   StudentId uniqueIdentifier,
	CONSTRAINT PK_class_student PRIMARY KEY (Id),
	CONSTRAINT FK_Enrolment_Class FOREIGN KEY (ClassId)
        REFERENCES Class(Id),
	CONSTRAINT FK_Enrolment_Student FOREIGN KEY (StudentId)
        REFERENCES Student(Id),
);


insert into Gender values ( 1,'Male')
insert into Gender values ( 2,'Female')
insert into Gender values ( 3,'both')