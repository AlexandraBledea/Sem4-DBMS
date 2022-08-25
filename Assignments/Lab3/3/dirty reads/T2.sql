USE Lab3_DBMS;
GO

-- part 2; we can read uncommited data (dirty read)
SET TRAN ISOLATION LEVEL READ UNCOMMITTED
BEGIN TRAN
-- see update
SELECT * FROM Library
WAITFOR DELAY '00:00:06'
-- update was rolled back
SELECT * FROM Library
COMMIT TRAN

-- UPDATE Library SET Address = 'Sighetu Marmatiei, nr 25' WHERE ID = 1