--22.	Write SQL statements to insert in the `Users` table the names of all employees from the `Employees` table.
--	*	Combine the first and last names as a full name.
--	*	For username use the first letter of the first name + the last name (in lowercase).
--	*	Use the same for the password, and `NULL` for last login time.
USE TelerikAcademy

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