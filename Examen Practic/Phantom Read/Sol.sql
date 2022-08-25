USE ExamenPractic
GO 

-- solution: set transaction isolation level to serializable
-- because on the isolation level serializable a transaction also acquires locks on sets of objects that must remain unmodified,
-- so basically range locks are required and this in our case solves the phantom read problem

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
BEGIN TRANSACTION
SELECT * FROM PizzaShop
WAITFOR DELAY '00:00:05'
SELECT * FROM PizzaShop
COMMIT TRANSACTION