INSERT INTO [Customers] (
	   [First Name]
	  ,[Last Name]
	  ,[Email] 
	  ,[Gender] 
	  ,[Country] 
	  ,[City] 
	  ,[Phone]
      ,[Birthdate]
	  )

SELECT [First Name]
      ,[Last Name]
      ,[Email]
      ,[Gender]
      ,[Country]
      ,[City]
      ,[Phone]
      ,PARSE([Birthday] AS DATE USING 'AR-LB')
  FROM [Data]


 INSERT INTO [Categories](
	    [Category Name]
		)
 VALUES ('Cloths'),
	    ('Toys'),
		('Food'),
		('Drinks'),
		('Others')


 INSERT INTO [Products](
		[Product Name]
	   ,[Category]
	   ,[CategoryId]
	   ,[Price]
	   ,[Quantity]
	   ,[CustomerId]
	    )
 VALUES ('Shirt', 'Cloths', 1, 5.55, 3, 3),
		('Jeans', 'Cloths', 1, 15.32, 25, 1),
		('Dog-Toy', 'Toys', 2, 3.00, 2, 25),
		('Ball', 'Toys', 2, 1.55, 50, 15),
		('Hamburger', 'Food', 3, 4.25, 3, 33),
		('Hamburger', 'Food', 3, 4.25, 1, 30),
		('Coca-Cola', 'Drinks', 4, 2.60, 2, 9),
		('Coca-Cola', 'Drinks', 4, 2.60, 3, 12),
		('Coca-Cola', 'Drinks', 4, 2.60, 12, 22),
		('Random-thing', 'Others', 5, 123.33, 1, 3),
		('Random-thing', 'Others', 5, 123.33, 1, 25)

