--07.	Write a SQL query to find the number of all employees that have manager.
USE TelerikAcademy

SELECT COUNT(DISTINCT EE.EmployeeID) AS [Employees with manager]
FROM Employees EE
	 JOIN Employees MM
	 ON EE.ManagerID = MM.EmployeeID