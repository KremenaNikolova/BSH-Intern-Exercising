SELECT CONCAT(c.[First Name], ' ', c.[Last Name]) as [Customer Name],
	   p.[Product Name],
       p.[Category]
  FROM [Customers] AS c
  LEFT JOIN [CustomersProducts] AS cp
    ON c.[Id] = cp.[CustomerId]
  LEFT JOIN [Products] AS p
	ON cp.[ProductId] = p.[Id]