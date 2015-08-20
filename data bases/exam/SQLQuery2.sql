USE ToyStore
GO

SELECT Toys.Name, Toys.Price, Toys.Color
FROM Toys
INNER JOIN ToysCategories
	ON Toys.Id=ToysCategories.ToyId
INNER JOIN Categories
	ON Categories.Id=ToysCategories.CategorieId
WHERE Categories.Name='boys'
GO