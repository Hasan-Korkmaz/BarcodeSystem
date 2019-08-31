CREATE TRIGGER TriggerRef ON Customers
AFTER INSERT
AS BEGIN
 
DECLARE  @ID INT,
               @Name VARCHAR(150),
               @Surname VARCHAR(150)
 
SELECT @ID= CustomerID,
          @Name = CustomerName,
          @Surname = CustomerSurname
           FROM inserted
   IF EXISTS( SELECT * FROM inserted) AND NOT EXISTS (SELECT * FROM deleted) 
    BEGIN
             INSERT INTO RefCustomer(RefCustomerID, RefCustomerName, RefCustomerSurname, isActive)
              Values( @ID, @Name, @Surname, 1)
    END
END