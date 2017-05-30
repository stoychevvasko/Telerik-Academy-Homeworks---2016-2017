--17.	Write a SQL statement to create a table `Groups`. Groups should have unique name (use unique constraint).
--		*	Define primary key and identity column.
USE TelerikAcademy

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