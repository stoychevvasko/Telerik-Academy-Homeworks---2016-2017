--25.	Write a SQL query to display the average employee salary by department and job title.
USE TelerikAcademy

SELECT AVG(e.Salary) AS [Average salary],
	   e.JobTitle AS [Job title or Department]
FROM Employees e
		LEFT OUTER JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY e.JobTitle
UNION
SELECT AVG(E.Salary) AS [Average salary],
	   D.Name
FROM Employees E
	 LEFT OUTER JOIN Departments D
	 ON E.DepartmentId = D.DepartmentID
GROUP BY D.Name
		 