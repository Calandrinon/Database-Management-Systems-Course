BEGIN TRANSACTION
INSERT INTO Album (Name, ReleaseDate, AlbumArtLink) VALUES ('testalbum 12 may', '2021-01-03', '')
COMMIT TRANSACTION

DELETE FROM Album WHERE Name = 'testalbum 12 may'