--23.	Write a SQL statement that changes the password to `NULL` for all users that have not been in the system since 10.03.2010.
USE TelerikAcademy

UPDATE Users
SET [Password] = NULL
WHERE [LastLogin] < CONVERT(DATETIME, '2010-03-10')

SELECT *
FROM Users