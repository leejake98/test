CREATE PROCEDURE [dbo].[spPortfolio_FilterByPortfolioId]
	@PortfolioId int
AS
BEGIN
	SELECT [PortfolioId], [NameOfCompany], [NameOfMainProduct], [HomepageURL], [CEO], [YearCompanyWasFounded], [InitalUploadedDateTime], [UpdatedDateTime], [RankingUsedToSort], [TempSaveYN], [SubmitedYN], [ApprovedYN], [DelYN]
	FROM dbo.Portfolio 
	WHERE PortfolioId = @PortfolioId;

END