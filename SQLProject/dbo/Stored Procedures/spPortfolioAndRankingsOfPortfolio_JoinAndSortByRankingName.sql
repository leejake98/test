CREATE PROCEDURE [dbo].[spPortfolioAndRankingsOfPortfolio_JoinAndSortByRankingName]
	@PortfolioRankingName NVARCHAR
AS 

begin

SELECT *
FROM dbo.PortfolioJoinedByRanking


WHERE dbo.PortfolioJoinedByRanking.PortfolioRankingName = @PortfolioRankingName

END