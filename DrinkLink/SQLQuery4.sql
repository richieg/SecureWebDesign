ALTER TRIGGER [Trigger_OrderInsert]
	ON [dbo].[DrinkLinkOrder]
	FOR INSERT
	AS
	BEGIN
		SET NOCOUNT ON
		INSERT INTO DrinkLinkOrderStatus 
		SELECT i.dlOrderParentOrderId,0
		FROM inserted i
		WHERE i.dlOrderParentOrderId not in 
		(SELECT [DlOrderStatusOrderId] FROM [dbo].[DrinkLinkOrderStatus])

	END
