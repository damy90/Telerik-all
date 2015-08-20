USE ToyStore
GO

SELECT Manufacturers.Name,
(SELECT COUNT(*)
FROM Toys
INNER JOIN AgeRanges
	ON Toys.AgeRangeId=AgeRanges.Id
WHERE AgeRanges.MinAge>=5 AND AgeRanges.MaxAge<=10 AND Manufacturers.Id=Toys.ManufacturerId) AS [Count]
FROM Manufacturers

GO

--select Toys.Name
--from Toys