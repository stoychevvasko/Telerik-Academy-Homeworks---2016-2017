--19.	Write SQL statements to insert several records in the `Users` and `Groups` tables.
USE TelerikAcademy

BEGIN TRAN

INSERT INTO Users ([UserName], [Password], [FullName], [LastLogin], [GroupID])
VALUES ('RedOne', '7849e1d65de0028a7da5901ac5004462f238e467fd37320ca5fa5e86c9379652', 'Reddd TheFirst', NULL, 1),
		('Leslie123', '457af59805fa29a196a70ec12f0f042cd72e74dbee923b3204cc35d97c8956cf', 'Leslie Knope', GETDATE(), 2),
		('jerry', '671b16ed98a14f053aac09447d6f51cadb3654c59b9f33ddfecb0fc4797879c0', 'Garry Gergich', GETDATE(), 2),
		('notme', 'fedb5532f2a52d5a646f6e05d1ffd1e73f630a97ee4efc232807b03b3cc62710', 'Ron Swanson', GETDATE(), 2),
		('tom', '0bddce0a2102d6b93d1300908df4919e5a647940e495e748ac883687f2746f2b', 'Tom Haverford', GETDATE(), 2),
		('benwyatt', 'e8be84604783a904831cc91e68396c06eee57340caf097e235e3faf4976c3e6a', 'Ben Wyatt', GETDATE(), 2);

INSERT INTO Groups ([Name])
VALUES ('Managers'),
       ('Legacy')

-- Test the command and ROLLBACK. Then change ROLLBACK to COMMIT
SELECT * FROM Users
SELECT * FROM Groups
       
COMMIT TRAN