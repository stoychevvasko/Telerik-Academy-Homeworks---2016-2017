## 07. Intro to SQL
### _Homework_

#### 01.	What is SQL? What is DML? What is DDL? Recite the most important SQL commands.
  * **SQL** - **Structured Query Language** is a domain-specific language used in programming and designed for managing data held in a relational database management system (*RDBMS*),
    or for stream processing in a relational data stream management system (*RDSMS*). SQL allows defining and modifying the database schema, also searching and modifying table data.
    SQL includes the DML and DDL sub-languages within its formal body.
  * **DML** - **Data Manipulation Language** is a family of syntax elements similar to computer programming language used for ***selecting***, ***inserting***, ***deleting*** and ***updating*** data in a database. Performing read-only queries of data is sometimes also considered a component of DML. SQL is a popular data manipulation language (DML).
    * ```sql
       SELECT ... FROM ... WHERE ...
      ```
    * ```sql
       INSERT INTO ... VALUES ...
      ```
    * ```sql
       UPDATE ... SET ... WHERE ...
      ```
    * ```sql
       DELETE FROM ... WHERE ...
      ```
  * **DDL** - **Data Definition Language** or **Data Description Language** is a syntax similar to a computer programming language for defining data structures, especially database
    schemas. SQL uses a collection of imperative verbs to modify the schema of the database by ***adding***, ***changing***, or ***deleting*** definitions of tables or other
    elements. These statements can be freely mixed with other SQL statements, making the DDL not a separate language. 
    * ```sql
        CREATE ...
      ```
      * Creates a component in a relational database management system (RDBMS). Valid components to create are ***schemas***, ***tables***, ***views***, ***domains***, ***character sets***, ***collations***, ***translations***, and ***assertions***. Extended definitions allow for the creations of additional elements such as ***indices*** and ***user profiles***. *PostgreSQL* and *SQL Server*
    * ```sql
        CREATE TABLE ... ( [column definitions] ) [table parameters]
      ```
      * column definitions are a comma-separated list of items in the format ***[column name][data type]{null|not null}{column options}***
      * Primary key definition: ```sql PRIMARY KEY([comma separated column list])```
      * Constraints: ```sql {CONSTRAINT}[constraint definition]```
      * RDBMS functionality
    *e.g.*
    * ```sql
          CREATE TABLE employees (
            id            INTEGER       PRIMARY KEY,
            first_name    VARCHAR(50)   not null,
            last_name     VARCHAR(75)   not null,
            fname         VARCHAR(50)   not null,
            dateofbirth   DATE          not null
          );
      ```
#### 02.	What is Transact-SQL (T-SQL)?
  * **T-SQL** or **Transact-SQL" is an extension to the standard SQL language, standardly used in MS SQL Server. It supports ***if-statements***, ***loops***, ***exceptions***,
    ***stored procedures***, ***functions*** and ***triggers***. 
#### 03.	Start SQL Management Studio and connect to the database TelerikAcademy. Examine the major tables in the "TelerikAcademy" database.
#### 04..	Write a SQL query to find all information about all departments (use "TelerikAcademy" database).
	* ```sql
		USE TelerikAcademy
		SELECT * FROM Departments
	  ```
1.	Write a SQL query to find all department names.
	* ```sql
    	SELECT Name FROM Departments
  	  ```
1.	Write a SQL query to find the salary of each employee.
	* ```sql
  	  SELECT Salary FROM Employees
	  ```
1.	Write a SQL to find the full name of each employee.
	* ```sql
  	  SELECT FirstName + ' ' + LastName AS [Full Name]
  	  FROM Employees
	  ```
1.	Write a SQL query to find the email addresses of each employee (by his first and last name). Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". The produced column should be named "Full Email Addresses".
	* ```sql
  	  SELECT FirstName + '.' + LastName + '@telerik.com' AS [Employee Email]
  	  FROM Employees 
	  ```
1.	Write a SQL query to find all different employee salaries.
	* ```sql
  	  SELECT DISTINCT Salary AS [Unique Salaries] 
  	  FROM Employees 
	  ```
1.	Write a SQL query to find all information about the employees whose job title is “Sales Representative“.
	* ```sql
  	  SELECT * 
  	  FROM Employees 
  	  WHERE JobTitle = 'Sales Representative'
	  ```
1.	Write a SQL query to find the names of all employees whose first name starts with "SA".
	* ```sql
  	  SELECT * 
  	  FROM Employees 
  	  WHERE FirstName LIKE 'SA%'
	  ```
1.	Write a SQL query to find the names of all employees whose last name contains "ei".
	* ```sql
  	  SELECT * 
  	  FROM Employees 
  	  WHERE LastName LIKE '%ei%'
	  ```
1.	Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].
	* ```sql
  	  SELECT Salary 
  	  FROM Employees 
  	  WHERE Salary BETWEEN 20000 AND 30000
	  ```
1.	Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.
	* ```sql
  	  SELECT FirstName + ' ' + LastName, Salary
  	  FROM Employees
  	  WHERE Salary IN (12500, 14000, 23600, 25000)
  	  ORDER BY Salary ASC
	  ```
1.	Write a SQL query to find all employees that do not have manager.
	* ```sql
  	  SELECT *
  	  FROM Employees
  	  WHERE ManagerID IS NULL
	  ```
1.	Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.
	* ```sql
  	  SELECT * 
  	  FROM Employees
  	  WHERE Salary > 50000
  	  ORDER BY Salary DESC
	  ```
1.	Write a SQL query to find the top 5 best paid employees.
	* ```sql
  	  SELECT TOP 5 *
  	  FROM Employees
  	  ORDER BY Salary DESC
	  ```
1.	Write a SQL query to find all employees along with their address. Use inner join with `ON` clause.
	* ```sql
  	  SELECT *
  	  FROM Employees e
  	  JOIN Addresses a
  	  ON e.AddressID = a.AddressID
	  ```
1.	Write a SQL query to find all employees and their address. Use equijoins (conditions in the `WHERE` clause).
	* ```sql
  	  SELECT *
  	  FROM Employees e, Addresses a
  	  WHERE e.AddressID = a.AddressID
	  ```
1.	Write a SQL query to find all employees along with their manager.
	* ```sql
  	  SELECT e.FirstName + ' ' + E.LastName AS [Team member], 
	  	    m.FirstName + ' ' + m.LastName AS [Manager]
  	  FROM Employees e 
  	  JOIN Employees m 
  	  ON e.ManagerID = m.EmployeeID
	  ```
1.	Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: `Employees e`, `Employees m` and `Addresses a`.
	* ```sql
  	  SELECT e.FirstName + ' ' + E.LastName AS [Employee], 
  		  a.AddressText AS [Employee address],
  		  m.FirstName + ' ' + m.LastName AS [Manager]	
  	  FROM Employees e 
  		  JOIN Employees m 
  		  ON e.ManagerID = m.EmployeeID
  			  JOIN Addresses a
  			  ON e.AddressID = a.AddressID
	  ```
1.	Write a SQL query to find all departments and all town names as a single list. Use `UNION`.
	* ```sql
  	  SELECT d.Name
  	  FROM Departments d
  	  UNION
  	  SELECT t.Name
  	  FROM Towns t
	  ```
1.	Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.
	* ```sql
  	  SELECT m.FirstName + ' ' + m.LastName AS [Manager Name],
         	  e.FirstName + ' ' + e.LastName AS [Employee Name]
  	  FROM Employees m
      	  RIGHT OUTER JOIN Employees e
      	  ON e.ManagerID = m.EmployeeID
	  ```
	* ```sql
  	  SELECT e.FirstName + ' ' + e.LastName AS [Employee Name],
         	  m.FirstName + ' ' + m.LastName AS [Manager name]
  	  FROM Employees e
      	  LEFT OUTER JOIN Employees m
      	  ON e.ManagerID = m.EmployeeID
	  ```
1.	Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.
	* ```sql
  	  SELECT e.FirstName + ' ' + e.LastName AS [Employee Name],
	     	  d.Name AS [Department],
	     	  YEAR(e.HireDate) AS [Year Hired]
  	  FROM Employees e, Departments d
  	  WHERE e.DepartmentID = d.DepartmentID 
  		  AND (d.Name = 'Sales' OR d.Name = 'Finance')
      	  AND (YEAR(e.HireDate) BETWEEN 1995 AND 2005)
	  ```
