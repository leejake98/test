CREATE TABLE [dbo].[RankingsOfPortfolio]
(
	[RankingId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PortfolioId] INT NULL,
    [PortfolioRankingName] NVARCHAR(50) NULL, 
    [PortfolioRanking] INT NULL 
)
