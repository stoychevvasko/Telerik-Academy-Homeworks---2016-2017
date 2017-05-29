## 05. Advanced SQL
### _Homework_

1.	Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
	*	Use a nested `SELECT` statement.
    * ```sql
        USE TelerikAcademy

        SELECT FirstName + ' ' + LastName AS [Full employee name],
             	 Salary
        FROM Employees
        WHERE Salary = 
        	(
        		SELECT MIN(Salary)
        		FROM Employees
        	)
      ```
1.	Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.
  * ```sql
      SELECT FirstName + ' ' + LastName AS [Full employee name],
           	 Salary
      FROM Employees
      WHERE Salary < 
    	(
    		SELECT (MIN(Salary)*1.1)
    		FROM Employees
    	)
    ```
1.	Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department.
	*	Use a nested `SELECT` statement.
    * ```sql
          SELECT E.FirstName + ' ' + E.LastName AS [Full employee name],
          	E.Salary,
          	D.Name AS [Dept]
          FROM Employees E
          	JOIN Departments D
          	ON E.DepartmentID = D.DepartmentID
          WHERE Salary = 
          	(
          		SELECT MIN(Salary)
          		FROM Employees
          		WHERE E.DepartmentID = D.DepartmentID
          	)
      ```
1.	Write a SQL query to find the average salary in the department #1.
  * ```sql
        SELECT AVG(Salary) AS [Average salary], 
          	   D.Name AS [Department]
        FROM Employees E
        	JOIN Departments D
        	ON E.DepartmentID = D.DepartmentID
        WHERE D.DepartmentID = 1
        GROUP BY D.Name
    ```
1.	Write a SQL query to find the average salary  in the "Sales" department.
  * ```sql
        SELECT AVG(Salary) AS [Average salary], 
          	   DD.Name AS [Department]
        FROM Employees EE
        	JOIN Departments DD
        	ON EE.DepartmentID = DD.DepartmentID
        WHERE DD.Name = 'Sales'
        GROUP BY DD.Name
    ```
1.	Write a SQL query to find the number of employees in the "Sales" department.
  * ```sql
        SELECT COUNT(DISTINCT EE.EmployeeID) AS [Number of employees], 
        	     DD.Name AS [Department]
        FROM Employees EE
        	JOIN Departments DD
        	ON EE.DepartmentID = DD.DepartmentID		
        WHERE DD.Name = 'Sales'
        GROUP BY DD.Name
    ```
1.	Write a SQL query to find the number of all employees that have manager.
  * ```sql
        SELECT COUNT(DISTINCT EE.EmployeeID) AS [Employees with manager]
        FROM Employees EE
        	 JOIN Employees MM
        	 ON EE.ManagerID = MM.EmployeeID
    ```
1.	Write a SQL query to find the number of all employees that have no manager.
  * ```sql
        SELECT COUNT(DISTINCT EE.EmployeeID) AS [Employees with no manager]
        FROM Employees EE
        WHERE EE.ManagerID IS NULL
    ```
1.	Write a SQL query to find all departments and the average salary for each of them.
  * ```sql
        SELECT DD.Name AS [Department],
        	     AVG(EE.Salary) AS [Average salary of employees]
        FROM Departments DD,
          	 Employees EE
        WHERE EE.DepartmentID = DD.DepartmentID
        GROUP BY DD.Name  
    ```
1.	Write a SQL query to find the count of all employees in each department and for each town.
  * ```sql
    ```
1.	Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.
  * ```sql
    ```
1.	Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".
  * ```sql
    ```
1.	Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in `LEN(str)` function.
  * ```sql
    ```
1.	Write a SQL query to display the current date and time in the following format "`day.month.year hour:minutSELECT AVG(Salary) AS [Average salary], 
	   D.Name AS [Department]
FROM Employees E
	JOIN Departments D
	ON E.DepartmentID = D.DepartmentID
WHERE D.DepartmentID = 1
GROUP BY D.Namees:seconds:milliseconds`".
	*	Search in Google to find how to format dates in SQL Server.
  * ```sql
    ```
1.	Write a SQL statement to create a table `Users`. Users should have username, password, full name and last login time.
	*	Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
	*	Define the primary key column as identity to facilitate inserting records.
	*	Define unique constraint to avoid repeating usernames.
	*	Define a check constraint to ensure the password is at least 5 characters long.
    * ```sql
      ```
1.	Write a SQL statement to create a view that displays the users from the `Users` table that have been in the system today.
	*	Test if the view works correctly.
    * ```sql
      ```
1.	Write a SQL statement to create a table `Groups`. Groups should have unique name (use unique constraint).
	*	Define primary key and identity column.
    * ```sql
      ```
1.	Write a SQL statement to add a column `GroupID` to the table `Users`.
	*	Fill some data in this new column and as well in the `Groups table.
	*	Write a SQL statement to add a foreign key constraint between tables `Users` and `Groups` tables.
    * ```sql
      ```
1.	Write SQL statements to insert several records in the `Users` and `Groups` tables.
  * ```sql
    ```
1.	Write SQL statements to update some of the records in the `Users` and `Groups` tables.
  * ```sql
    ```
1.	Write SQL statements to delete some of the records from the `Users` and `Groups` tables.
  * ```sql
    ```
1.	Write SQL statements to insert in the `Users` table the names of all employees from the `Employees` table.
	*	Combine the first and last names as a full name.
	*	For username use the first letter of the first name + the last name (in lowercase).
	*	Use the same for the password, and `NULL` for last login time.
    * ```sql
      ```
1.	Write a SQL statement that changes the password to `NULL` for all users that have not been in the system since 10.03.2010.
  * ```sql
    ```
1.	Write a SQL statement that deletes all users without passwords (`NULL` password).
  * ```sql
    ```
1.	Write a SQL query to display the average employee salary by department and job title.
  * ```sql
    ```
1.	Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.
  * ```sql
    ```
1.	Write a SQL query to display the town where maximal number of employees work.
  * ```sql
    ```
1.	Write a SQL query to display the number of managers from each town.
  * ```sql
    ```
1.	Write a SQL to create table `WorkHours` to store work reports for each employee (employee id, date, task, hours, comments).
	*	Don't forget to define  identity, primary key and appropriate foreign key. 
	*	Issue few SQL statements to insert, update and delete of some data in the table.
	*	Define a table `WorkHoursLogs` to track all changes in the `WorkHours` table with triggers.
		*	For each change keep the old record data, the new record data and the command (insert / update / delete).
      * ```sql
        ```
1.	Start a database transaction, delete all employees from the '`Sales`' department along with all dependent records from the pother tables.
	*	At the end rollback the transaction.
    * ```sql
      ```
1.	Start a database transaction and drop the table `EmployeesProjects`.
	*	Now how you could restore back the lost table data?
    * ```sql
      ```
1.	Find how to use temporary tables in SQL Server.
	*	Using temporary tables backup all records from `EmployeesProjects` and restore them back after dropping and re-creating the table.
    * ```sql
      ```
