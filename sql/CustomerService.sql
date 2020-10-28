CREATE DATABASE CustomerService

CREATE TABLE Customers
................ (
................ ID UNIQUEIDENTIFIER not null,
................ CustomerNo int NOT NULL,
................ Name nvarchar(20) NOT NULL,
................ Surname nvarchar(20) NOT NULL,
................ PassportNo nvarchar(8) NOT NULL
................ )


