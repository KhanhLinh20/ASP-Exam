create database CompanyDB

use CompanyDB

create table Employees
(
	Id int primary key identity(1,1),
	Name varchar(60),
	DoB datetime,
	Address varchar(100),
	Email varchar(40)
)

INSERT INTO Employees VALUES
('Thuy', '2000-10-09', 'Vietnam', 'nick@gmail.com'),
('Long Tran', '1996-02-22', '290 NKKN, Q3, HCMC', 'longtran@outlook.com'),
('Anh', '2023-10-02', 'UK', 'nick@gmail.com');