SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
BEGIN TRANSACTION
SELECT * FROM Album;
WAITFOR DELAY '00:00:05'
SELECT * FROM Album;
-- A dirty read occurs at the line above, before the transaction from transaction_update.sql rolls back
COMMIT TRANSACTION


SET TRANSACTION ISOLATION LEVEL READ COMMITTED
BEGIN TRANSACTION
SELECT * FROM Album;
WAITFOR DELAY '00:00:05'
SELECT * FROM Album;
-- No dirty read occurs at the line above, because the isolation level is READ COMMITED
COMMIT TRANSACTION