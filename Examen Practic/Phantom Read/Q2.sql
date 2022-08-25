USE ExamenPractic
GO 

-- part 2: phantom read - because T1 has generated a new row while T2 is executing, we will get an extra row in the second select

SET TRANSACTION ISOLATION LEVEL REPEATABLE READ
BEGIN TRANSACTION
-- inserted value does not exist yet
SELECT * FROM PizzaShop
WAITFOR DELAY '00:00:05'
-- we can see the inserted value during the second read
SELECT * FROM PizzaShop
COMMIT TRANSACTION