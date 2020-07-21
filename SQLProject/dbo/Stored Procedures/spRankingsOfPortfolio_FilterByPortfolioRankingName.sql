CREATE PROCEDURE [dbo].[spRankingsOfPortfolio_FilterByPortfolioRankingName]
	@PortfolioId int

AS
BEGIN
	SELECT [RankingId], [PortfolioId], [PortfolioRankingName], [PortfolioRanking]
	FROM dbo.RankingsOfPortfolio
	WHERE (PortfolioId = @PortfolioId);

END