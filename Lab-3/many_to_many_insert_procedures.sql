CREATE OR ALTER PROCEDURE addArtist(@ArtistName VARCHAR(50), @EstablishmentYear SMALLINT)
AS
    INSERT INTO Artist (Name, EstablishmentYear) VALUES (@ArtistName, @EstablishmentYear)
GO

CREATE OR ALTER PROCEDURE addAlbum(@AlbumName VARCHAR(50), @ReleaseDate DATE, @AlbumArtLink VARCHAR(200))
AS
    INSERT INTO Album (Name, ReleaseDate, AlbumArtLink) VALUES (@AlbumName, @ReleaseDate, @AlbumArtLink)
GO

CREATE OR ALTER PROCEDURE addArtistAlbumAssociation(@ArtistName VARCHAR(50), @AlbumName VARCHAR(50))
AS
    DECLARE @ArtistId INT = (SELECT ArtistId FROM Artist WHERE Name = @ArtistName)
    DECLARE @AlbumId INT = (SELECT AlbumId FROM Album WHERE Name = @AlbumName)

    IF @ArtistId IS NULL
    BEGIN
        PRINT '@ArtistId is null...'
        EXEC addArtist @ArtistName, NULL
        SET @ArtistId = (SELECT ArtistId FROM Artist WHERE Name = @ArtistName)
    END

    IF @AlbumId IS NULL
    BEGIN
        PRINT '@AlbumId is null...'
        DECLARE @CurrentDate DATE = CAST(GETDATE() as DATE)
        EXEC addAlbum @AlbumName, @CurrentDate, ''
        SET @AlbumId = (SELECT AlbumId FROM Album WHERE Name = @AlbumName)
    END

    IF (SELECT COUNT(*) FROM Artists_Albums WHERE ArtistId = @ArtistId AND AlbumId = @AlbumId) > 0
    BEGIN
        RAISERROR ('An association between the given artist and album already exists.', 2, 1)
        RETURN
    END

    INSERT INTO Artists_Albums (ArtistId, AlbumId) VALUES (@ArtistId, @AlbumId)
GO

CREATE OR ALTER PROCEDURE addAssociationInsideATransaction(@ArtistName VARCHAR(50), @AlbumName VARCHAR(50))
AS
    BEGIN TRANSACTION

    BEGIN TRY
        EXEC addArtistAlbumAssociation @ArtistName, @AlbumName
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        RETURN
    END CATCH
GO

CREATE OR ALTER PROCEDURE failedScenario
AS
    EXEC addAssociationInsideATransaction 'Pink Floyd', 'Dark Side Of The Moon'
GO

CREATE OR ALTER PROCEDURE successfulScenario
AS
    EXEC addAssociationInsideATransaction 'Pink Floyd', 'The Final Cut'
GO

/**
 DON'T USE IDs AS PARAMETERS!
**/

EXEC failedScenario
EXEC successfulScenario
SELECT * FROM Artists_Albums;
SELECT * FROM Album;
DELETE FROM Album WHERE AlbumId = 20
DELETE FROM Artists_Albums WHERE AlbumId = 20