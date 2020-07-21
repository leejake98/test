CREATE TABLE [dbo].[Portfolio]
(
	[PortfolioId] INT NOT NULL IDENTITY, 
    [NameOfCompany] NVARCHAR(50) NULL, 
    [NameOfMainProduct] NVARCHAR(50) NULL, 
    [HomepageURL] NVARCHAR(50) NULL,
    [CEO] NVARCHAR(50) NULL, 
    [YearCompanyWasFounded] NVARCHAR(10) NULL,
    [ParticipatedNextround] INT NULL,
    [InitalUploadedDateTime] DATETIME NULL, 
    [UpdatedDateTime] DATETIME NULL, 
    [RankingUsedToSort] INT NULL,
    [TempSaveYN] BIT NULL, 
    [SubmitedYN] BIT NULL, 
    [ApprovedYN] BIT NULL, 
    [DelYN] BIT NULL

)
