  
/*
    NAME:   Peter Linton
    DATE:   2026-06-20
	UPDATED: 2026-06-23
    CLASS:  Summer Project
    PURPOSE:Establish Connection to Northwind DB
	PURPOSE:Supporting Queries for working with SqlDataReader
*/

USE Northwind;
GO


SELECT * FROM Customers ;

SELECT * FROM Customers ORDER BY CustomerID ASC;
SELECT ContactName, CompanyName, CustomerID FROM Customers ORDER BY CustomerID ASC;

SELECT * FROM Northwind.dbo.Cusotmers ORDER BY CustomerID ASC;

