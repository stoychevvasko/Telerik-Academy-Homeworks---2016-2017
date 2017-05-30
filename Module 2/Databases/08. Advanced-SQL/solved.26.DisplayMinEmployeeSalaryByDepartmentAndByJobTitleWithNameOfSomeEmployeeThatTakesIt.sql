--26.	Write a SQL query to display the minimal employee salary by department and job title along with the 
--name of some of the employees that take it.
USE TelerikAcademy

SELECT MIN(e.Salary) AS [Minimal salary],
	   e.JobTitle AS [Job title or Department],
	   MIN(e.FirstName + ' ' + e.LastName + ' - ( min salary within job title )') AS [Sample employee]
FROM Employees e        		
GROUP BY e.JobTitle

UNION

SELECT MIN(E.Salary) AS [Minimal salary],
	   D.Name AS [Department],
	   MIN(E.FirstName + ' ' + E.LastName + ' - ( min salary within dept )')
FROM Employees E
	 LEFT OUTER JOIN Departments D
	 ON E.DepartmentId = D.DepartmentID
GROUP BY D.Name