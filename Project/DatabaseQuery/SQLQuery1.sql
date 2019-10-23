CREATE DATABASE ProjectDB
USE ProjectDB

CREATE TABLE Category
(
	Category_Id int IDENTITY(1,1),
	Category_Code VARCHAR(20),
    Category_Name VARCHAR(20)
)
Drop TABLE Category
Select * From Category
delete from Category