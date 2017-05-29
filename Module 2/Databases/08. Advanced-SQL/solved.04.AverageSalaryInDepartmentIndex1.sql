--04.	Write a SQL query to find the average salary in the department #1.
  USE TelerikAcademy

  SELECT AVG(Salary) AS [Average salary], 
		 DD.Name AS [Department]
  FROM Employees EE
	JOIN Departments DD
	ON EE.DepartmentID = DD.DepartmentID
  WHERE DD.DepartmentID = 1
  GROUP BY DD.Name