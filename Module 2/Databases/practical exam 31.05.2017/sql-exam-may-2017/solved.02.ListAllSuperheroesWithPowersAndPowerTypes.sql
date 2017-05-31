--02.List all superheroes with their powers and powerTypes
USE SuperheroesUniverse
GO
SELECT s.Name AS [Superhero],
	   p.Name + ' (' + pt.Name + ')' AS [Power]
FROM Superheroes s
		JOIN PowerSuperheroes ps
		ON ps.Superhero_Id = s.Id
			JOIN Powers p
			ON ps.Power_Id = p.Id
				JOIN PowerTypes pt
				ON p.PowerTypeId = pt.Id
GROUP BY s.Name,
	     pt.Name,
		 p.Name
GO