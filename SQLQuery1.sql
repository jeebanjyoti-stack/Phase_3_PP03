create database SchoolPP_3
use SchoolPP_3

create table Student(
Id int primary key not null identity,
StudentName nvarchar(50) not null,
TotalMarks float not null,
Class nvarchar(20) not null)

insert into Student values ('Harry',500,8)

select * from Student