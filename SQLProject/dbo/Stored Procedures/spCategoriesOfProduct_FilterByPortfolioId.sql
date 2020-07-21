CREATE PROCEDURE [dbo].[spCategoriesOfProduct_FilterByPortfolioId]
	@PortfolioId int
AS
BEGIN
	SELECT [CategoryId], [PortfolioId], [ProductCategory]
	FROM dbo.CategoriesOfProduct
	WHERE PortfolioId = @PortfolioId;

END