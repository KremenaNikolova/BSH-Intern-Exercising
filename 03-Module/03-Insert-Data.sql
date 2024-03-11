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