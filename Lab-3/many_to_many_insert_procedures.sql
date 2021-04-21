CREATE OR ALTER PROCEDURE addArtist(@ArtistName VARCHAR(50), @EstablishmentYear SMALLINT)
AS
    INSERT INTO Artist (Name, EstablishmentYear) VALUES (@ArtistName, @EstablishmentYear)
GO

CREATE OR ALTER PROCEDURE addAlbum(@AlbumName VARCHAR(50), @ReleaseDate DATE, @AlbumArtLink VARCHAR(200))
AS
    INSERT INTO Album (Name, ReleaseDate, AlbumArtLink) VALUES (@AlbumName, @ReleaseDate, @AlbumArtLink)
GO

SELECT * FROM Artist;

/**
 DON'T USE IDs AS PARAMETERS!
 Get the last Artist/Album and obtain the ID of each of them,
 then try to add a many-to-many association in Artists_Albums

CREATE OR ALTER PROCEDURE addAlbumByArtist(@ArtistId INT, @AlbumId INT)
AS
    IF (SELECT COUNT(*) FROM Artist WHERE ArtistId = @ArtistId) = 0
    BEGIN
        RAISERROR('There is no artist with the given ID!', 19, 1)
    END

    IF (SELECT COUNT(*) FROM Album WHERE AlbumId = @AlbumId) = 0
    BEGIN
        RAISERROR('There is no album with the given ID!', 19, 1)
    END

    IF (SELECT COUNT(*) FROM Artists_Albums WHERE A)

GO
**/