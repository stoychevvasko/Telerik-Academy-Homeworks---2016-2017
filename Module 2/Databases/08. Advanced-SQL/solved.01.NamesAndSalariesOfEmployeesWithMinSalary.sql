--1.	Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
USE TelerikAcademy

SELECT FirstName + ' ' + LastName AS [Full employee name],
	   Salary
FROM Employees
WHERE Salary = (
		SELECT MIN(Salary)
		FROM Employees
	)