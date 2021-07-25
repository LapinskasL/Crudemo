CREATE PROCEDURE [dbo].[PersonsInsertPerson]
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@PhoneNumber NVARCHAR(20),
	@InsertedId INT OUTPUT
AS
	DECLARE @InsertedIdTable TABLE (Id INT) 

    INSERT INTO Persons (FirstName, LastName, PhoneNumber) 
    OUTPUT INSERTED.Id INTO @InsertedIdTable(Id)
    VALUES (@FirstName, @LastName, @PhoneNumber)

    SET @InsertedId = (SELECT TOP 1 Id FROM @InsertedIdTable)
