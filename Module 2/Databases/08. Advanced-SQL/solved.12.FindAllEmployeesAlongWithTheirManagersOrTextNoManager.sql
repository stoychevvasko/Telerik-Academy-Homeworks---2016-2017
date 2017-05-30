--12.	Write a SQL query to find all employees along with their managers. 
--For employees that do not have manager display the value "(no manager)".
USE TelerikAcademy

SELECT EE.FirstName + ' ' + EE.LastName AS [Employee Name],
	   COALESCE(MM.FirstName + ' ' + MM.LastName, 'no manager') AS [Manager Name]
FROM Employees EE
	   LEFT OUTER JOIN Employees MM
	   ON EE.ManagerID = MM.EmployeeID