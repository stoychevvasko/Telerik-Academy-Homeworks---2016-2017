--15. Write a SQL statement to create a table Users. Users should have username, password, full name and last login time.
-- Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
-- Define the primary key column as identity to facilitate inserting records.
-- Define unique constraint to avoid repeating usernames.
-- Define a check constraint to ensure the password is at least 5 characters long.

BEGIN TRAN

CREATE TABLE Users
(
	ID int IDENTITY,
	[UserName] varchar(20) NOT NULL,
	[Password] varchar(100) NOT NULL,
	[FullName] varchar(50) NOT NULL,
	[LastLogin] dateTime,
	CONSTRAINT PK_Users PRIMARY KEY(ID),
	CONSTRAINT UK_UserName UNIQUE(UserName),
	CONSTRAINT Check_Password CHECK(LEN([Password])>=5)
)

INSERT INTO Users (UserName, [Password], FullName, LastLogin)
VALUES ('User', '$5$MnfsQ4iN$ZMTppKN16y/tIsUYs/obHlhdP.Os80yXhTurpBMUbA5', 'User Sample', NULL);
        
INSERT INTO Users (UserName, [Password], FullName, LastLogin)
VALUES ('User2', '$5$rounds=5000$usesomesillystri$KqJWpanXZHKq2BOB43TSaYhEWsQ1Lr5QNyPCDH/Tp.6 ', 'User2 Sample', NULL);

INSERT INTO Users (UserName, [Password], FullName, LastLogin)
VALUES ('NewUser', '7dc5c078dcd6d4b374b90a85d66ce0da4526773fb3844faab90300c2efa1fcb3', 'Todays User', GETDATE());

-- Test the command and rollback. Then change ROLLBACK to COMMIT
SELECT * FROM Users

COMMIT TRAN