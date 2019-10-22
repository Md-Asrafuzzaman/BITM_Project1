CREATE DATABASE Projectdb

CREATE TABLE Product
(
	Product_Id INT IDENTITY(1,1),
	Product_Code VARCHAR(30),
	Product_Name VARCHAR(30),
	Product_Category VARCHAR(30),
	Product_RecordedLevel VARCHAR(30),
	Product_Description VARCHAR(30)
)


CREATE TABLE Category
(
	Catergory_Id INT IDENTITY(1,1),
	Category_Code VARCHAR(30),
	Category_Name VARCHAR(30),
)

CREATE TABLE Customer
(
	Customer_Id INT IDENTITY(1,1),
	Customer_Code VARCHAR(30),
	Customer_Name VARCHAR(30),
	Customer_Address VARCHAR(30),
	Customer_Email VARCHAR(30),
	Customer_Contact VARCHAR(30),
	Customer_Loyality VARCHAR(30)
)
