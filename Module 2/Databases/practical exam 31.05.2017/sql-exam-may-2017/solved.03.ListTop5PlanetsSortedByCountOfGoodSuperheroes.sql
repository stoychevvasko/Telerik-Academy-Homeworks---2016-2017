--03.List the top 5 planets, sorted by count of superheroes with alignment 'Good', then by Planet Name
USE SuperheroesUniverse
GO
SELECT p.Name AS [Planet],
       COUNT(DISTINCT s.Name) AS [Protectors]	   
FROM Superheroes s
		JOIN PlanetSuperheroes ps
		ON s.Id = ps.Superhero_Id
			JOIN Planets p
			ON p.Id = ps.Planet_Id
				JOIN Alignments a
				ON a.Id = s.Alignment_Id
WHERE a.Name = 'Good'
GROUP BY p.Name	     
ORDER BY [Protectors] DESC,
	     p.Name ASC
GO