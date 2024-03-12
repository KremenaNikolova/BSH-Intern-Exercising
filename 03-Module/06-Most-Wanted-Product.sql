SELECT TOP(1)
	   p.[Product Name]
	  ,SUM(cp.[Quantity]) as [Total Sells Quantity]
  FROM [CustomersProducts] AS cp
  JOIN [Products] as p
    ON p.[Id] = cp.[ProductId]
 GROUP BY p.[Product Name]