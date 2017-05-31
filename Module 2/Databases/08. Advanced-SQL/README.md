## 08. Advanced SQL
### _Homework_

#### 01.	Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
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
#### 02.	Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.
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
#### 03.	Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department.
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
#### 04.	Write a SQL query to find the average salary in the department #1.
  * ```sql
        SELECT AVG(Salary) AS [Average salary], 
          	   D.Name AS [Department]
        FROM Employees E
        	JOIN Departments D
        	ON E.DepartmentID = D.DepartmentID
        WHERE D.DepartmentID = 1
        GROUP BY D.Name
    ```
#### 05.	Write a SQL query to find the average salary  in the "Sales" department.
  * ```sql
        SELECT AVG(Salary) AS [Average salary], 
          	   DD.Name AS [Department]
        FROM Employees EE
        	JOIN Departments DD
        	ON EE.DepartmentID = DD.DepartmentID
        WHERE DD.Name = 'Sales'
        GROUP BY DD.Name
    ```
#### 06.	Write a SQL query to find the number of employees in the "Sales" department.
  * ```sql
        SELECT COUNT(DISTINCT EE.EmployeeID) AS [Number of employees], 
        	     DD.Name AS [Department]
        FROM Employees EE
        	JOIN Departments DD
        	ON EE.DepartmentID = DD.DepartmentID		
        WHERE DD.Name = 'Sales'
        GROUP BY DD.Name
    ```
#### 07.	Write a SQL query to find the number of all employees that have manager.
  * ```sql
        SELECT COUNT(DISTINCT EE.EmployeeID) AS [Employees with manager]
        FROM Employees EE
        	 JOIN Employees MM
        	 ON EE.ManagerID = MM.EmployeeID
    ```
#### 08.	Write a SQL query to find the number of all employees that have no manager.
  * ```sql
        SELECT COUNT(DISTINCT EE.EmployeeID) AS [Employees with no manager]
        FROM Employees EE
        WHERE EE.ManagerID IS NULL
    ```
#### 09.	Write a SQL query to find all departments and the average salary for each of them.
  * ```sql
        SELECT DD.Name AS [Department],
        	     AVG(EE.Salary) AS [Average salary of employees]
        FROM Departments DD,
          	 Employees EE
        WHERE EE.DepartmentID = DD.DepartmentID
        GROUP BY DD.Name  
    ```
#### 10.	Write a SQL query to find the count of all employees in each department and for each town.
  * ```sql
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
    ```
#### 11.	Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.
  * ```sql
        SELECT MM.FirstName + ' ' +  MM.LastName AS [Manager of 5 employees],
               COUNT(*) AS [Number of Employees]
        FROM Employees EE
            INNER JOIN Employees MM
        	  ON EE.ManagerID = MM.EmployeeID
        GROUP BY EE.ManagerID, 
        	     MM.FirstName, 
        		   MM.LastName
        HAVING COUNT(*) = 5
    ```
#### 12.	Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".
  * ```sql
        SELECT EE.FirstName + ' ' + EE.LastName AS [Employee Name],
        	   COALESCE(MM.FirstName + ' ' + MM.LastName, 'no manager') AS [Manager Name]
        FROM Employees EE
        	   LEFT OUTER JOIN Employees MM
        	   ON EE.ManagerID = MM.EmployeeID  
    ```
#### 13.	Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in `LEN(str)` function.
  * ```sql
        SELECT FirstName + ' ' + LastName AS [Employee Name]
        FROM Employees
        WHERE LEN(LastName) = 5
    ```
#### 14.	Write a SQL query to display the current date and time in the following format "`day.month.year hour:minutes:seconds:milliseconds`".
	*	Search in Google to find how to format dates in SQL Server.
  * ```sql
        SELECT FORMAT(GETDATE(),'dd.MM.yyyy HH:mm:ss:f') AS [Current Time]
    ```
#### 15.	Write a SQL statement to create a table `Users`. Users should have username, password, full name and last login time.
	*	Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
	*	Define the primary key column as identity to facilitate inserting records.
	*	Define unique constraint to avoid repeating usernames.
	*	Define a check constraint to ensure the password is at least 5 characters long.
    * ```sql
        BEGIN TRAN

        CREATE TABLE Users
        (
        	ID int IDENTITY,
        	[UserName] varchar(20) NOT NULL,
        	[Password] varchar(100) NOT NULL,
        	[FullName] varchar(50) NOT NULL,
        	[LastLogin] dateTime,
        	CONSTRAINT PK_Users PRIMARY KEY(ID),
        	CONSTRAINT UK_UserName UNIQUE(UserName),
        	CONSTRAINT Check_Password CHECK(LEN([Password])>=5)
        )

        INSERT INTO Users (UserName, [Password], FullName, LastLogin)
        VALUES ('User', '$5$MnfsQ4iN$ZMTppKN16y/tIsUYs/obHlhdP.Os80yXhTurpBMUbA5', 'User Sample', NULL);
        
        INSERT INTO Users (UserName, [Password], FullName, LastLogin)
        VALUES ('User2', '$5$rounds=5000$usesomesillystri$KqJWpanXZHKq2BOB43TSaYhEWsQ1Lr5QNyPCDH/Tp.6 ', 'User2 Sample', NULL);

        INSERT INTO Users (UserName, [Password], FullName, LastLogin)
        VALUES ('NewUser', '7dc5c078dcd6d4b374b90a85d66ce0da4526773fb3844faab90300c2efa1fcb3', 'Todays User', GETDATE());

        -- Test the command and rollback. Then change ROLLBACK to COMMIT
        SELECT * FROM Users

        COMMIT TRAN
      ```
#### 16.	Write a SQL statement to create a view that displays the users from the `Users` table that have been in the system today.
	*	Test if the view works correctly.
    * ```sql
          CREATE VIEW [UsersFromToday] AS
          SELECT * FROM Users
          WHERE FORMAT(GETDATE(),'yyyyMMdd') = FORMAT(LastLogin,'yyyyMMdd')

          SELECT * 
          FROM [UsersFromToday]
      ```
#### 17.	Write a SQL statement to create a table `Groups`. Groups should have unique name (use unique constraint).
	*	Define primary key and identity column.
    * ```sql
          BEGIN TRAN

          CREATE TABLE [Groups]
          (
          	[Id] int IDENTITY,
          	[Name] nvarchar(100) NOT NULL,
          	CONSTRAINT PK_Groups PRIMARY KEY(Id),
          	CONSTRAINT UK_Name UNIQUE(Name)
          )

          INSERT INTO Groups (Name)
          VALUES ('Admins');

          INSERT INTO Groups (Name)
          VALUES ('Users');

          INSERT INTO Groups (Name)
          VALUES ('Interactive');

          -- Test the command and rollback. Then change ROLLBACK to COMMIT
          SELECT * FROM Groups

          COMMIT TRAN
      ```
#### 18.	Write a SQL statement to add a column `GroupID` to the table `Users`.
	*	Fill some data in this new column and as well in the `Groups table.
	*	Write a SQL statement to add a foreign key constraint between tables `Users` and `Groups` tables.
    * ```sql
        BEGIN TRAN

        ALTER TABLE Users
        ADD GroupId int
        GO

        ALTER TABLE Users
        ADD CONSTRAINT FK_Users_Groups
        FOREIGN KEY(GroupId)
        REFERENCES Groups(ID)

   -- Updating already existing users with a GroupID
        UPDATE Users SET GroupID = 1 WHERE ID = 1
        UPDATE Users SET GroupID = 2 WHERE ID = 2
        UPDATE Users SET GroupID = 2 WHERE ID = 3

        -- Test the command and rollback. Then change ROLLBACK to COMMIT
        SELECT * FROM Users
        COMMIT TRAN
      ```
#### 19.	Write SQL statements to insert several records in the `Users` and `Groups` tables.
  * ```sql
        INSERT INTO Users ([UserName], [Password], [FullName], [LastLogin], [GroupID])
        VALUES ('RedOne', '7849e1d65de0028a7da5901ac5004462f238e467fd37320ca5fa5e86c9379652', 'Reddd TheFirst', NULL, 1),
        		('Leslie123', '457af59805fa29a196a70ec12f0f042cd72e74dbee923b3204cc35d97c8956cf', 'Leslie Knope', GETDATE(), 2),
		        ('jerry', '671b16ed98a14f053aac09447d6f51cadb3654c59b9f33ddfecb0fc4797879c0', 'Garry Gergich', GETDATE(), 2),
		        ('notme', 'fedb5532f2a52d5a646f6e05d1ffd1e73f630a97ee4efc232807b03b3cc62710', 'Ron Swanson', GETDATE(), 2),
		        ('tom', '0bddce0a2102d6b93d1300908df4919e5a647940e495e748ac883687f2746f2b', 'Tom Haverford', GETDATE(), 2),
        		('benwyatt', 'e8be84604783a904831cc91e68396c06eee57340caf097e235e3faf4976c3e6a', 'Ben Wyatt', GETDATE(), 2);

        INSERT INTO Groups ([Name])
        VALUES ('Managers'),
               ('Legacy')

        -- Test the command and ROLLBACK. Then change ROLLBACK to COMMIT
        SELECT * FROM Users
        SELECT * FROM Groups
       
        COMMIT TRAN
    ```
#### 20.	Write SQL statements to update some of the records in the `Users` and `Groups` tables.
  * ```sql
        UPDATE Users 
        SET GroupID = g.ID
        FROM 
        (
            SELECT ID, Name 
            FROM Groups 
            WHERE Name = 'Managers'
        ) g
        WHERE UserName = 'notme'

        SELECT * FROM Users WHERE UserName = 'notme'
    ```
#### 21.	Write SQL statements to delete some of the records from the `Users` and `Groups` tables.
  * ```sql
        DELETE FROM Users
        WHERE ID = 1

        DELETE FROM Groups
        WHERE Name = 'Legacy'

        SELECT * 
        FROM Users

        SELECT * 
        FROM Groups
    ```
#### 22. (TODO: fix)	Write SQL statements to insert in the `Users` table the names of all employees from the `Employees` table.
	*	Combine the first and last names as a full name.
	*	For username use the first letter of the first name + the last name (in lowercase).
	*	Use the same for the password, and `NULL` for last login time.
    * ```sql
          BEGIN TRAN

          INSERT INTO Users ([UserName], [Password], [FullName], [LastLogin], [GroupID])
          SELECT LEFT(LOWER(EE.FirstName), 3) + LOWER(EE.LastName),
          	   LEFT(LOWER(EE.FirstName), 3) + LOWER(EE.LastName),
          	   EE.FirstName + ' ' + EE.LastName,
          	   Null,
          	   2
          FROM Employees EE

          SELECT * 
          FROM Users

          COMMIT TRAN
      ```
#### 23.	Write a SQL statement that changes the password to `NULL` for all users that have not been in the system since 10.03.2010.
  * ```sql
        UPDATE Users
        SET [Password] = NULL
        WHERE [LastLogin] < CONVERT(DATETIME, '2010-03-10')

        SELECT *
        FROM Users
    ```
#### 24.	Write a SQL statement that deletes all users without passwords (`NULL` password).
  * ```sql
        DELETE FROM Users
        WHERE Password IS NULL

        SELECT *
        FROM Users
    ```
#### 25.	Write a SQL query to display the average employee salary by department and job title.
  * ```sql
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
    ```
#### 26.	Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.
  * ```sql
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
    ```
#### 27.	Write a SQL query to display the town where maximal number of employees work.
  * ```sql
        SELECT TOP 1 t.Name AS [Town],
        	   COUNT(DISTINCT e.EmployeeId) as [Headcount]	   
        FROM Employees e,
        	 Addresses a,
        	 Towns t
        WHERE e.AddressID = a.AddressID
        	  AND a.TownID = t.TownID
        GROUP BY t.Name
    ```
#### 28.	Write a SQL query to display the number of managers from each town.
  * ```sql
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
    ``` 
#### 29.	Write a SQL to create table `WorkHours` to store work reports for each employee (employee id, date, task, hours, comments).
	*	Don't forget to define  identity, primary key and appropriate foreign key. 
	*	Issue few SQL statements to insert, update and delete of some data in the table.
	*	Define a table `WorkHoursLogs` to track all changes in the `WorkHours` table with triggers.
		*	For each change keep the old record data, the new record data and the command (insert / update / delete).
      * ```sql

        ```
#### 30.	Start a database transaction, delete all employees from the '`Sales`' department along with all dependent records from the pother tables.
	*	At the end rollback the transaction.
    * ```sql
      ```
#### 31.	Start a database transaction and drop the table `EmployeesProjects`.
	*	Now how you could restore back the lost table data?
    * ```sql
      ```
#### 32.	Find how to use temporary tables in SQL Server.
	*	Using temporary tables backup all records from `EmployeesProjects` and restore them back after dropping and re-creating the table.
    * ```sql
      ```
