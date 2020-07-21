CREATE PROCEDURE [dbo].[spPortfolio_GetMaxId]

	
AS
BEGIN
	SELECT MAX( [PortfolioId])
	FROM dbo.Portfolio


END