--20.	Write SQL statements to update some of the records in the `Users` and `Groups` tables.
USE TelerikAcademy

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