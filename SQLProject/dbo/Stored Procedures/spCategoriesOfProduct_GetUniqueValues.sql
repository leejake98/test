CREATE PROCEDURE [dbo].[spCategoriesOfProduct_GetUniqueValues]
	
AS
BEGIN
	SELECT distinct [ProductCategory]
	FROM dbo.CategoriesOfProduct


END