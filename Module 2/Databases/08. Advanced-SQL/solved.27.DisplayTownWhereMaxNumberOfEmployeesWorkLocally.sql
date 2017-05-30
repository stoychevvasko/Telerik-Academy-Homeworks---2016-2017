--27.	Write a SQL query to display the town where maximal number of employees work.
USE TelerikAcademy

SELECT TOP 1 t.Name AS [Town],
	   COUNT(DISTINCT e.EmployeeId) as [Headcount]	   
FROM Employees e,
	 Addresses a,
	 Towns t
WHERE e.AddressID = a.AddressID
	  AND a.TownID = t.TownID
GROUP BY t.Name
