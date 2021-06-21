CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NCHAR(10) NOT NULL, 
    [Price] NCHAR(10) NOT NULL, 
    [Type] NCHAR(10) NOT NULL, 
    [Producer] NCHAR(10) NOT NULL, 
    [Warranty] NCHAR(10) NULL
)
