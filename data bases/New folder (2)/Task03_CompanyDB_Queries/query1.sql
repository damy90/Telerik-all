use [Company]

SELECT [FirstName] + ' ' + [LastName] AS [Full Name] , 
		[YearSalary]
		
FROM [dbo].[Employees]
WHERE [YearSalary]>=100000 AND [YearSalary]<=150000
ORDER BY [YearSalary]

GO