--10.	Write a SQL query to find the count of all employees in each department and for each town.
USE TelerikAcademy

SELECT DD.Name AS [Department],
	   TT.Name AS [Town],
	   COUNT(*) AS [Number of employees]
FROM Employees EE
	 INNER JOIN Departments DD
	 ON EE.DepartmentID = DD.DepartmentID
		INNER JOIN Addresses AA		
		ON EE.AddressID = AA.AddressID
			INNER JOIN Towns TT 
			ON AA.TownID = TT.TownID
GROUP BY DD.Name,
		 TT.Name
ORDER BY DD.Name,
		 TT.Name