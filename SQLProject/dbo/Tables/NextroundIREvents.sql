CREATE TABLE [dbo].[NextroundIREvents]
(
	[NextroundIRId] INT NOT NULL IDENTITY, 
    [NameOfHostingOrganization] NVARCHAR(50) NULL, 
    [URLOfLogoImage] NVARCHAR(50) NULL, 
    [NextroundIRNumber] INT NULL,
    [EventDateTime] DATETIME NULL

)
