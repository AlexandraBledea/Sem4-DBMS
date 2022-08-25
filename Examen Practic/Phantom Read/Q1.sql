USE ExamenPractic
GO 

--INSERT INTO PizzaShop VALUES ('New shop', 'New Address')
--SELECT * FROM PizzaShop
--DELETE FROM PizzaShop WHERE SName = 'New shop'

-- part 1
BEGIN TRANSACTION
WAITFOR DELAY '00:00:05'
INSERT INTO PizzaShop VALUES ('New shop', 'New Address')
COMMIT TRANSACTION

-- The phantom reads occurs because we have a repeating read operation on the same table, but a new record appears at the second read
-- The phantom reads problem occurs when range locks are not acquired on performing a SELECT