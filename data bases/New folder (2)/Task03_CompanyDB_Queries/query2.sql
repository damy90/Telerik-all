use [Company]

SELECT d.Name as Department, Count(e.DepartmentID) AS [Number of Employees]

FROM [dbo].[Departments] d, [dbo].[Employees] e 

WHERE d.ID=e.DepartmentID

GROUP BY d.Name, e.DepartmentID

ORDER BY Count(e.DepartmentID) DESC

GO