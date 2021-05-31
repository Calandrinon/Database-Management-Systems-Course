ALTER DATABASE OnlineMusicStore SET ALLOW_SNAPSHOT_ISOLATION ON

WAITFOR DELAY '00:00:10'
BEGIN TRANSACTION
UPDATE Album SET ReleaseDate = '1972-01-01' WHERE AlbumId = 17
WAITFOR DELAY '00:00:10'
COMMIT TRANSACTION