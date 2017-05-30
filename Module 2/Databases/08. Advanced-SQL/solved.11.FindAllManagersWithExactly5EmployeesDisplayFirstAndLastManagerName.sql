--11.	Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.
USE TelerikAcademy

SELECT MM.FirstName + ' ' +  MM.LastName AS [Manager of 5 employees],
       COUNT(*) AS [Number of Employees]
FROM Employees EE
    INNER JOIN Employees MM
	ON EE.ManagerID = MM.EmployeeID
GROUP BY EE.ManagerID, 
	     MM.FirstName, 
		 MM.LastName
HAVING COUNT(*) = 5