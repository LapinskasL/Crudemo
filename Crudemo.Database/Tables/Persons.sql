CREATE TABLE [dbo].[Persons]
(
	[Id]          INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]   NVARCHAR (50) NOT NULL,
    [LastName]    NVARCHAR (50) NOT NULL,
    [PhoneNumber] NVARCHAR (20) NOT NULL,
    [AddressId]   INT           NOT NULL,
    [ConcurrencyToken] ROWVERSION NOT NULL,
    [DateAdded] DATETIME2(7) DEFAULT(GETDATE()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
)
