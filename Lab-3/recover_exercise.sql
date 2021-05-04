/**
    Create a stored procedure that inserts data in tables that are in a m:n relationship.
    If an insert fails, try to recover as much as possible from the entire operation:
        for example, if the user wants to add a book and its authors, succeeds creating
        the authors, but fails with the book, the authors should remain in the database.
**/


CREATE OR ALTER FUNCTION validateArtistNameAndEstablishmentYear(@ArtistName VARCHAR(50), @EstablishmentYear SMALLINT)
RETURNS INT
AS
BEGIN
    IF @ArtistName IS NULL OR @EstablishmentYear IS NULL
        BEGIN
            RETURN 0
        END

    RETURN 1
END


CREATE OR ALTER FUNCTION validateAlbumParameters(@AlbumName VARCHAR(50), @ReleaseDate DATE)
RETURNS INT
AS
BEGIN
    IF @AlbumName IS NULL OR @ReleaseDate IS NULL
        BEGIN
            RETURN 0
        END

    RETURN 1
END

CREATE OR ALTER PROCEDURE addArtist(@ArtistName VARCHAR(50), @EstablishmentYear SMALLINT)
AS
    BEGIN TRANSACTION
    BEGIN TRY
        IF (dbo.validateArtistNameAndEstablishmentYear(@ArtistName, @EstablishmentYear) <> 1)
        BEGIN
            RAISERROR ('The artist name and establishment year cannot be null.', 6, 1)
        END
        INSERT INTO Artist (Name, EstablishmentYear) VALUES (@ArtistName, @EstablishmentYear)
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        PRINT 'Artist could not be inserted. The transaction has been rolled back.'
    END CATCH
GO

CREATE OR ALTER PROCEDURE addAlbum(@AlbumName VARCHAR(50), @ReleaseDate DATE, @AlbumArtLink VARCHAR(200))
AS
    BEGIN TRANSACTION
    BEGIN TRY
        IF (dbo.validateAlbumParameters(@AlbumName, @ReleaseDate) <> 1)
        BEGIN
            RAISERROR ('The album name and release date cannot be null.', 6, 1)
        END
        INSERT INTO Album (Name, ReleaseDate, AlbumArtLink) VALUES (@AlbumName, @ReleaseDate, @AlbumArtLink)
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        PRINT 'Album could not be inserted. The transaction has been rolled back.'
    END CATCH
GO

CREATE OR ALTER PROCEDURE addArtistAlbumAssociation(@ArtistName VARCHAR(50), @AlbumName VARCHAR(50))
AS
    DECLARE @ArtistId INT = (SELECT ArtistId FROM Artist WHERE Name = @ArtistName)
    DECLARE @AlbumId INT = (SELECT AlbumId FROM Album WHERE Name = @AlbumName)

    IF @AlbumId IS NULL
    BEGIN
        PRINT '@AlbumId is null...'
        DECLARE @CurrentDate DATE = CAST(GETDATE() as DATE)
        EXEC addAlbum @AlbumName, @CurrentDate, ''
        PRINT 'Adding the album worked!'
        SET @AlbumId = (SELECT AlbumId FROM Album WHERE Name = @AlbumName)
    END

    IF @ArtistId IS NULL
    BEGIN
        PRINT '@ArtistId is null...'
        EXEC addArtist @ArtistName, 1900
        SET @ArtistId = (SELECT ArtistId FROM Artist WHERE Name = @ArtistName)
    END

    IF (SELECT COUNT(*) FROM Artists_Albums WHERE ArtistId = @ArtistId AND AlbumId = @AlbumId) > 0
    BEGIN
        RAISERROR ('An association between the given artist and album already exists.', 2, 1)
        RETURN
    END

    INSERT INTO Artists_Albums (ArtistId, AlbumId) VALUES (@ArtistId, @AlbumId)
GO


CREATE OR ALTER PROCEDURE associationInsertion(@ArtistName VARCHAR(50), @AlbumName VARCHAR(50))
AS
    BEGIN TRY
        EXEC addArtistAlbumAssociation @ArtistName, @AlbumName
        PRINT 'The association was successfully inserted.'
    END TRY
    BEGIN CATCH
        PRINT 'The association transaction has been rolled back.'
    END CATCH
GO

CREATE OR ALTER PROCEDURE failedScenario
AS
    EXEC associationInsertion NULL, 'Relayer'
GO

CREATE OR ALTER PROCEDURE successfulScenario
AS
    EXEC associationInsertion 'Rush', 'Signals'
GO

/**
 DON'T USE IDs AS PARAMETERS!
**/

SELECT * FROM Artist;
SELECT * FROM Album;
EXEC failedScenario
EXEC successfulScenario
SELECT * FROM Artists_Albums;
SELECT * FROM Album;
DELETE FROM Album WHERE AlbumId = 20
DELETE FROM Artists_Albums WHERE AlbumId = 20

EXEC addAlbum 'ab', NULL, NULL