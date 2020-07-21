CREATE TABLE [dbo].[ImageFilesOfProduct]
(
	[ImageFileId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PortfolioId] INT NOT NULL, 
    [ImageFileAddress] NVARCHAR(50) NULL
)
