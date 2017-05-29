--05.	Write a SQL query to find the average salary  in the "Sales" department.
  USE TelerikAcademy

SELECT AVG(Salary) AS [Average salary], 
	   DD.Name AS [Department]
FROM Employees EE
	 JOIN Departments DD
	 ON EE.DepartmentID = DD.DepartmentID
WHERE DD.Name = 'Sales'
GROUP BY DD.Name