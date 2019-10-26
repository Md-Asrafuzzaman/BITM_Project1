CREATE DATABASE Module1
USE Module1

CREATE TABLE ProductCategorys
(
Id INT IDENTITY (1,1),
Code VARCHAR(4),
Name VARCHAR(MAX)
)
UPDATE ProductCategorys  SET Code='aass',Name ='poo' WHERE Id =1
SELECT * FROM ProductCategorys
SELECT * FROM ProductCategorys Where Code = 'srrr'