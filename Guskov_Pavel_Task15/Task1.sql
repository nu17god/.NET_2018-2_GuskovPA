USE master
IF(db_id(N'UsersAndAwards')) IS NOT NULL DROP DATABASE UsersAndAwards
GO

CREATE DATABASE UsersAndAwards
GO

USE UsersAndAwards
GO

CREATE TABLE Users(
	[Id] int not null primary key identity(1,1),
	[FirstName] nvarchar(50),
	[SecondName] nvarchar(50),
	[Birthdate] DATE,
	)

USE UsersAndAwards
CREATE TABLE Awards(
	[Id] int not null primary key identity(1,1),
	[Name] nvarchar(50) UNIQUE,
	[Description] nvarchar(250)
	)

CREATE TABLE Relations
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[UserId] INT NOT NULL,
	[AwardId] INT NOT NULL,
	FOREIGN KEY (UserId) REFERENCES Users(Id) ON DELETE CASCADE,
	FOREIGN KEY (AwardId) REFERENCES Awards(Id) ON DELETE CASCADE
)
GO


CREATE PROCEDURE AddUser
(
	@firstName nvarchar(50),
	@secondName nvarchar(50),
	@birthdate DATE
)

AS
BEGIN
	INSERT INTO Users
	OUTPUT INSERTED.Id
	VALUES(@firstName, @secondName, @birthdate)
END
GO

CREATE PROCEDURE RemoveUser
(
	@id int
)

AS
BEGIN
	DELETE 
	FROM dbo.Users
	WHERE Id = @id
END

GO
CREATE PROCEDURE UpdateUser
(
	@id int,
	@firstName nvarchar(50),
	@secondName nvarchar(50),
	@birthdate DATE
)

AS
BEGIN
	UPDATE dbo.Users
	SET [FirstName] = @firstName,[SecondName] = @secondName, [Birthdate] = @birthdate
	FROM dbo.Users
	WHERE Id = @id

	DELETE 
	FROM dbo.Relations
	WHERE dbo.Relations.UserId = @id
END
GO

CREATE PROCEDURE AddAward
(
	@title nvarchar(50),
	@des nvarchar(250)
)
AS
BEGIN
	INSERT INTO dbo.Awards
	VALUES(@title, @des)
END
GO

CREATE PROCEDURE RemoveAward
(
	@id int
)

AS
BEGIN
	DELETE 
	FROM dbo.Awards
	WHERE Id = @id
END

GO
CREATE PROCEDURE UpdateAward
(
	@id int,
    @name nvarchar(50),
	@des nvarchar(250)
)

AS
BEGIN
	UPDATE dbo.Awards
	SET [Name] = @name, [Description] = @des
	FROM dbo.Awards
	WHERE Id = @id
END
GO

CREATE PROCEDURE GetUser
(
	@id int
)

AS
BEGIN
	SELECT dbo.Users.Id, dbo.Users.FirstName, dbo.Users.SecondName, dbo.Users.Birthdate
	FROM dbo.Users
	WHERE dbo.Users.Id = @id
END
GO

CREATE PROCEDURE SetUserAward
(
	@awardId int,
	@userId int
)
AS
BEGIN
INSERT INTO dbo.Relations
VALUES (@userId, @awardId)
END
GO 

CREATE PROCEDURE GetAwards

AS
BEGIN
	SELECT *
	FROM dbo.Awards

END
GO

CREATE PROCEDURE GetAward
(
	@ID int
)
AS
BEGIN
	SELECT *
	FROM dbo.Awards
	WHERE @ID = Id
END
GO

CREATE PROCEDURE GetUsersAwards
(
	@ID int
)
AS
BEGIN
	SELECT dbo.Awards.Id, dbo.Awards.Name, dbo.Awards.Description
	FROM dbo.Relations join dbo.Awards on dbo.Relations.AwardId =  dbo.Awards.Id
	WHERE UserId = @ID
END
GO

CREATE PROCEDURE GetUsersId
AS
BEGIN
	SELECT dbo.Users.Id
	FROM dbo.Users
END
GO