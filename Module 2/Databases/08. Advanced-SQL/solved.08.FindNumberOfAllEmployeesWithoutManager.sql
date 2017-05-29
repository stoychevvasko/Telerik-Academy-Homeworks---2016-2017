--08.	Write a SQL query to find the number of all employees that have no manager.
USE TelerikAcademy

SELECT COUNT(DISTINCT EE.EmployeeID) AS [Employees with no manager]
FROM Employees EE
WHERE EE.ManagerID IS NULL