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
	    )
 VALUES ('Shirt', 'Cloths', 1, 5.55, 3),
		('Jeans', 'Cloths', 1, 15.32, 25),
		('Dog-Toy', 'Toys', 2, 3.00, 2),
		('Ball', 'Toys', 2, 1.55, 50),
		('Hamburger', 'Food', 3, 4.25, 3),
		('Chips', 'Food', 3, 4.25, 1),
		('Coca-Cola', 'Drinks', 4, 2.60, 2),
		('Tea', 'Drinks', 4, 2.60, 3),
		('Soda', 'Drinks', 4, 2.60, 12),
		('Random-thing', 'Others', 5, 123.33, 1),
		('Random-thing 2', 'Others', 5, 123.33, 1)

INSERT INTO [CustomersProducts](
	   [CustomerId]
	  ,[ProductId]
	  ,[Quantity]
	   )
VALUES (3, 1, 2),
	   (1, 1, 1),
	   (33, 3, 11),
	   (12, 5, 3),
	   (56, 5, 1),
	   (3, 2, 1)
		

