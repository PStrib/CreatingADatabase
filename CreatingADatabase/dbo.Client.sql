CREATE TABLE [dbo].[Table]
(
	[ClientID] INT NOT NULL PRIMARY KEY, 
    [ContactForename] NVARCHAR(50) NOT NULL, 
    [ContactSurname] NVARCHAR(50) NOT NULL, 
    [BusinessName] NVARCHAR(50) NOT NULL, 
    [HouseNo] INT NOT NULL, 
    [Street] NVARCHAR(50) NOT NULL, 
    [Town] NVARCHAR(50) NOT NULL, 
    [Postcode] NCHAR(10) NOT NULL, 
    [County] NVARCHAR(50) NOT NULL, 
    [ContactNo] NVARCHAR(50) NOT NULL, 
    [ContactEmail] NVARCHAR(50) NOT NULL
)
