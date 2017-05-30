--16.	Write a SQL statement to create a view that displays the users from the `Users` table that have been in the system today.
USE TelerikAcademy

CREATE VIEW [UsersFromToday] AS
SELECT * FROM Users
WHERE FORMAT(GETDATE(),'yyyyMMdd') = FORMAT(LastLogin,'yyyyMMdd')

SELECT * 
FROM [UsersFromToday]
