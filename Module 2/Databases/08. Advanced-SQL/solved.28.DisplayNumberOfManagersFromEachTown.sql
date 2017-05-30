--28.	Write a SQL query to display the number of managers from each town.
USE TelerikAcademy

SELECT t.Name AS [Town],
	   COUNT(DISTINCT m.EmployeeID) AS [Manager headcount]
FROM Employees e
		JOIN Employees m
		ON e.ManagerID = m.EmployeeID
			JOIN Addresses a
			ON m.AddressID = a.AddressID
				JOIN Towns t
				ON a.TownID = t.TownID
WHERE e.ManagerID = m.EmployeeID
	  AND m.AddressID = a.AddressID
	  AND a.TownID = t.TownID
GROUP BY t.Name
ORDER BY [Manager headcount] DESC