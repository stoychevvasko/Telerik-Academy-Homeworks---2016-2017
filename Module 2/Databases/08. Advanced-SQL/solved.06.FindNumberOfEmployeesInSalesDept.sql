--06.	Write a SQL query to find the number of employees in the "Sales" department.
USE TelerikAcademy

SELECT COUNT(DISTINCT EE.EmployeeID) AS [Number of employees], 
	   DD.Name AS [Department]
FROM Employees EE
	JOIN Departments DD
	ON EE.DepartmentID = DD.DepartmentID		
WHERE DD.Name = 'Sales'
GROUP BY DD.Name