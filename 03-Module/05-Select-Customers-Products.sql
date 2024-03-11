SELECT CONCAT(c.[First Name], ' ', c.[Last Name]) as [Customer Name],
	   p.[Product Name],
       p.[Category]
  FROM [Customers] AS c
LEFT JOIN [Products] AS p
    ON c.Id = p.CustomerId