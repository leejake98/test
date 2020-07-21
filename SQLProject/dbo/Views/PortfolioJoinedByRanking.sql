CREATE VIEW [dbo].[PortfolioJoinedByRanking]
AS 
SELECT [p].[PortfolioId], [p].[NameOfCompany], [p].[NameOfMainProduct], [p].[HomepageURL],
       [p].[CEO], [p].[YearCompanyWasFounded], [p].[InitalUploadedDateTime], [p].[UpdatedDateTime],
       [p].[RankingUsedToSort], [p].[TempSaveYN], [p].[SubmitedYN], [p].[ApprovedYN], [p].[DelYN], [r].[RankingId],
       [r].[PortfolioRankingName], [r].[PortfolioRanking]
FROM dbo.Portfolio p
LEFT JOIN dbo.RankingsOfPortfolio r
ON p.PortfolioId = r.PortfolioId