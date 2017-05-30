--21. Write SQL statements to delete some of the records from the Users and Groups tables.
USE TelerikAcademy

DELETE FROM Users
WHERE ID = 1

DELETE FROM Groups
WHERE Name = 'Legacy'

SELECT * 
FROM Users

SELECT * 
FROM Groups