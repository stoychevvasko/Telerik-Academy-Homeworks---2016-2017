--05. Create a stored prodecure, that gives full information about a superhero, by provided Superhero's Id
-- Name it usp_GetSuperheroInfo
USE SuperheroesUniverse
GO
CREATE PROCEDURE dbo.usp_GetSuperheroInfo(@superheroId int = -1)
AS
	SELECT s.Id AS [Id],
		   s.Name AS [Name],
		   s.SecretIdentity AS [Secret Identity],
		   s.Bio AS [Bio],
		   a.Name AS [Alignment],
		   p.Name AS [Planet],
		   pw.Name AS [Power]
	FROM Superheroes s			
			JOIN PlanetSuperheroes ps
			ON ps.Superhero_Id = s.Id
				JOIN Planets p
				ON ps.Planet_Id = p.Id					
					JOIN PowerSuperheroes pws
					ON pws.Superhero_Id = s.Id
						JOIN Powers pw
						ON pw.Id = pws.Power_Id
			JOIN Alignments a
			ON s.Alignment_Id = a.Id
	WHERE s.Id = @superheroId											
GO
--tests
DECLARE @testId int = 3;
EXECUTE dbo.usp_GetSuperheroInfo @testId
GO
--cleanup
DROP PROCEDURE dbo.usp_GetSuperheroInfo
GO
