CREATE TABLE [dbo].[CategoriesOfProduct]
(
	[CategoryId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PortfolioId] INT NULL,
    [ProductCategory] NVARCHAR(50) NULL 

)
