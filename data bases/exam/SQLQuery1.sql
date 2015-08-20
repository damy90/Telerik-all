USE ToyStore
GO

SELECT Toys.Name, Toys.Price
FROM Toys
WHERE Toys.Price>100 AND Toys.Type='puzzle'
ORDER BY Toys.Price
GO