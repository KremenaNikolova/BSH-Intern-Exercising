--First option
SELECT p.[Product Name]
  FROM [Products] as p
 WHERE p.CategoryId = 1

 --Second option
 SELECT p.[Product Name]
  FROM [Products] as p
 WHERE p.Category LIKE 'Food'
