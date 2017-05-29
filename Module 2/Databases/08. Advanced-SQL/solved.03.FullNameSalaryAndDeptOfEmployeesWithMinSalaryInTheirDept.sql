--03.	Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department.
--*	Use a nested `SELECT` statement.
USE TelerikAcademy

SELECT EE.FirstName + ' ' + EE.LastName AS [Full employee name],
	   Salary,
	   DD.Name AS [Department]
FROM Employees EE
	JOIN Departments DD
	ON EE.DepartmentID = DD.DepartmentID
WHERE Salary = (
	SELECT MIN(Salary)
	FROM Employees eE
	WHERE eE.DepartmentID = DD.DepartmentID
)