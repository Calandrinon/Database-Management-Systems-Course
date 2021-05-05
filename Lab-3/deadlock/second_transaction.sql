BEGIN TRANSACTION
UPDATE Artist SET Name = 'Ponk Fleed' WHERE ArtistId = 1
WAITFOR DELAY '00:00:10'
UPDATE Album SET ReleaseDate = '1972-01-05' WHERE AlbumId = 17
COMMIT TRANSACTION


SET DEADLOCK_PRIORITY HIGH -- this increases the deadlock priority of this transaction
-- therefore, the other transaction will be chosen as the deadlock victim
BEGIN TRANSACTION
UPDATE Artist SET Name = 'Ponk Fleed' WHERE ArtistId = 1
WAITFOR DELAY '00:00:10'
UPDATE Album SET ReleaseDate = '1972-01-05' WHERE AlbumId = 17
COMMIT TRANSACTION