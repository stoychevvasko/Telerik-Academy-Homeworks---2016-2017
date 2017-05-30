--18.	Write a SQL statement to add a column `GroupID` to the table `Users`.
--		*	Fill some data in this new column and as well in the `Groups table.
--		*	Write a SQL statement to add a foreign key constraint between tables `Users` and `Groups` tables.
USE TelerikAcademy

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