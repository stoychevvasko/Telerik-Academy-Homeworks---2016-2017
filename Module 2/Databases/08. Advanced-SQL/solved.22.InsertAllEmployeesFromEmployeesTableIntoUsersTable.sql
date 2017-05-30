--22.	Write SQL statements to insert in the `Users` table the names of all employees from the `Employees` table.
--	*	Combine the first and last names as a full name.
--	*	For username use the first letter of the first name + the last name (in lowercase).
--	*	Use the same for the password, and `NULL` for last login time.
USE TelerikAcademy

BEGIN TRAN

INSERT INTO Users ([UserName], [Password], [FullName], [LastLogin], [GroupID])
SELECT LOWER(SUBSTRING(e.FirstName, 1, 1)) + LOWER(e.LastName) AS [UserName],
	   LOWER(SUBSTRING(e.FirstName, 1, 1)) + LOWER(e.LastName)  AS [Password],
	   e.FirstName + ' ' + e.LastName AS [FullName],
	   Null AS [LastLogin],
	   NULL AS [GroupID]
FROM Employees e
ORDER BY [UserName]

SELECT * 
FROM Users

ROLLBACK TRAN



