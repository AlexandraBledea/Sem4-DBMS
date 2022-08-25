USE Lab3_DBMS
GO

--solution: set transaction isolation level to repeatable read
SET TRAN ISOLATION LEVEL REPEATABLE READ
BEGIN TRAN
SELECT * FROM Library
WAITFOR DELAY '00:00:06'
-- now we see the value before the update
SELECT * FROM Library
COMMIT TRAN

-- DELETE FROM Library WHERE ID = 2