--09.	Write a SQL query to find all departments and the average salary for each of them.
USE TelerikAcademy

SELECT DD.Name AS [Department],
	   AVG(EE.Salary) AS [Average salary of employees]
FROM Departments DD,
	 Employees EE
WHERE EE.DepartmentID = DD.DepartmentID
GROUP BY DD.Name