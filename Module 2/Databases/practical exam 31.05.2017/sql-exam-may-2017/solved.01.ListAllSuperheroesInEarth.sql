--01. List all superheroes in Earth
USE SuperheroesUniverse
GO
SELECT s.Name AS [Name]
FROM Superheroes s
		JOIN PlanetSuperheroes ps
		ON s.Id = ps.Superhero_Id
			JOIN Planets p
			ON ps.Planet_Id = p.Id
WHERE p.Name = 'Earth'
GO