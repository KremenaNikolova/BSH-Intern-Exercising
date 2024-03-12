USE [Online Shop]


CREATE TABLE [Categories](
	   [Id] INT PRIMARY KEY IDENTITY,
	   [Category Name] NVARCHAR(50) NOT NULL
	   )

CREATE TABLE [Customers](
	   [Id] INT PRIMARY KEY IDENTITY,
	   [First Name] NVARCHAR(50) NOT NULL,
	   [Last Name] NVARCHAR(50) NOT NULL,
	   [Email] VARCHAR(80) NOT NULL,
	   [Gender] VARCHAR(10) NOT NULL,
	   [Country] NVARCHAR(100) NOT NULL,
	   [City] NVARCHAR(100) NOT NULL,
	   [Phone] VARCHAR(15) NOT NULL,
	   [Birthdate] DATETIME NOT NULL
	   )

	
CREATE TABLE [Products](
	   [Id] INT PRIMARY KEY IDENTITY,
	   [Product Name] NVARCHAR(100) NOT NULL,
	   [Category] NVARCHAR(50) NOT NULL,
	   [CategoryId] INT FOREIGN KEY REFERENCES [Categories](Id) NOT NULL,
	   [Price] DECIMAL NOT NULL,
	   [Quantity] INT NOT NULL
	   )

CREATE TABLE [CustomersProducts](
	   [CustomerId] INT FOREIGN KEY REFERENCES [Customers](Id),
	   [ProductId] INT FOREIGN KEY REFERENCES [Products](Id),
	   PRIMARY KEY([CustomerId], [ProductId]),
	   [Quantity] INT NOT NULL
	   )
