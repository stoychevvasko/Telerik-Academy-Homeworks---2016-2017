--04.Create a stored procedure to edit superheroes Bio, by provided Superhero's Id and the new bio
USE SuperheroesUniverse
GO
CREATE PROCEDURE dbo.usp_UpdateSuperheroBio(@superheroId int = -1, @newBio ntext = NULL)
AS
	UPDATE Superheroes
	SET Bio = @newBio
	WHERE Id = @superheroId
GO
--tests
DECLARE @testId int = 1;
EXEC dbo.usp_UpdateSuperheroBio @testId, "new bio added!"
SELECT * 
FROM Superheroes s
WHERE s.Id = @testId
GO
--cleanup
DROP PROCEDURE dbo.usp_UpdateSuperheroBio
GO
