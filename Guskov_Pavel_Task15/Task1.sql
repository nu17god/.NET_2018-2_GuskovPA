USE master
IF(db_id(N'UsersAndAwards')) IS NOT NULL DROP DATABASE UsersAndAwards

CREATE DATABASE UsersAndAwards
USE UsersAndAwards

CREATE TABLE Users(
	[Id] int not null primary key identity(1,1),
	[Name] nvarchar(50),
	[Birthdate] DATE
	)

INSERT INTO Users
VALUES(N'Ivanov', '1972-05-02')
INSERT INTO Users
VALUES(N'Petrov', '1980-07-22')
INSERT INTO Users
VALUES(N'Kuznecov', '1950-12-24')

USE UsersAndAwards
CREATE TABLE Awards(
	[Id] int not null primary key identity(1,1),
	[Name] nvarchar(50),
	[Description] nvarchar(250)
	)

INSERT INTO Awards
VALUES(N'Nobel award', N'')
INSERT INTO Awards
VALUES(N'Snobel award', N'')

CREATE TABLE Relations
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[UserId] INT NOT NULL,
	[AwardId] INT NOT NULL,
	FOREIGN KEY (UserId) REFERENCES Users(Id) ON DELETE CASCADE,
	FOREIGN KEY (AwardId) REFERENCES Awards(Id) ON DELETE CASCADE
)

INSERT INTO Relations
VALUES(1, 1), (1,2),(2,2)



GO
CREATE PROCEDURE AddUser
(
	@name nvarchar(50),
	@birthdate DATE
)

AS
BEGIN
	INSERT INTO Users
	VALUES(@name, @birthdate)
END

GO
CREATE PROCEDURE DeleteUser
(
	@id int
)

AS
BEGIN
	DELETE 
	FROM dbo.Users
	WHERE Id = @id

	DELETE 
	FROM dbo.Relations
	WHERE UserId = @id
END

GO
CREATE PROCEDURE RefreshUser
(
	@id int,
    @name nvarchar(50),
	@birthdate DATE
)

AS
BEGIN
	UPDATE dbo.Users
	SET [Name] = @name, [Birthdate] = @birthdate
	FROM dbo.Users
	WHERE Id = @id
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
CREATE PROCEDURE DeleteAward
(
	@id int
)

AS
BEGIN
	DELETE 
	FROM dbo.Awards
	WHERE Id = @id

	DELETE 
	FROM dbo.Relations
	WHERE AwardId = @id
END

GO
CREATE PROCEDURE RefreshAward
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
CREATE PROCEDURE GetUserInfo
(
	@id int
)

AS
BEGIN
	SELECT dbo.Users.Name, dbo.Users.Birthdate, dbo.Awards.Name, dbo.Awards.Description
	FROM (dbo.Relations JOIN dbo.Awards ON dbo.Relations.AwardId = dbo.Awards.Id) JOIN dbo.Users ON dbo.Relations.UserId = dbo.Users.Id
	WHERE dbo.Users.Id = @id
END
