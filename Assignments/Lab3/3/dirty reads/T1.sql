USE Lab3_DBMS
GO

-- part 1
BEGIN TRAN
UPDATE Library
SET Address = 'Cluj Napoca, nr 10'
WHERE ID = 1
WAITFOR DELAY '00:00:06'
ROLLBACK TRAN