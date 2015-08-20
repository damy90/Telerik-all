use [Company]

SELECT e.[FirstName] + ' ' + e.[LastName] AS [Full Name] ,
		p.Name AS [Project Name],
		ep.StartDate AS [Start Date],
		ep.EndDate AS [End Date],
		d.Name AS [Department],
		(SELECT Count(r.ID) 
			FROM [dbo].[Reports] r 
			WHERE r.ReportTime>ep.StartDate 
					AND r.ReportTime<ep.EndDate
					AND r.EmployeeID=e.ID 
			GROUP BY r.EmployeeID
		) AS [Number Of Reports]

FROM [dbo].[Employees] e,
		[dbo].[Departments] d, 
		[dbo].[Projects] p,
		[dbo].[EmployeesProject] ep,
		[dbo].[Reports] r

WHERE e.ID=ep.EmployeeID
		AND ep.ProjectID=p.ID 
		AND e.DepartmentID=d.ID
		AND r.EmployeeID=e.ID


ORDER BY e.ID,p.ID

		 