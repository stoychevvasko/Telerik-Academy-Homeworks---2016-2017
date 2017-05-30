--14. Write a SQL query to display the current date and time in the following format 
--"day.month.year hour:minutes:seconds:milliseconds".
USE TelerikAcademy

SELECT FORMAT(GETDATE(),'dd.MM.yyyy HH:mm:ss:f') AS [Current Time]