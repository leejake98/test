CREATE PROCEDURE [dbo].[spImageFilesOfProduct_FilterByPortfolioId]
	@PortfolioId int
AS
BEGIN
	SELECT [ImageFileId], [PortfolioId], [ImageFileAddress]
	FROM dbo.ImageFilesOfProduct
	WHERE PortfolioId = @PortfolioId;

END