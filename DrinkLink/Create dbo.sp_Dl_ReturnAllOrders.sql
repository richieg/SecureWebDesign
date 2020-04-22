USE [DrinkLInk]
GO

/****** Object: SqlProcedure [dbo].[sp_Dl_ReturnAllOrders] Script Date: 22/04/2020 10:42:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



ALTER PROC sp_Dl_UpdateUserRole @userId varchar(50), @role varchar(50)
AS
BEGIN

INSERT INTO AspNetUserRoles SELECT 
dlc.DlContactOwnership, aspr.Id
FROM DrinkLinkContacts dlc ,
AspNetRoles aspr
WHERE aspr.Name = @role
AND dlc.DlContactOwnership = @userId
AND dlc.DlContactOwnership NOT IN (SELECT UserId FROM AspNetUserRoles)

Update DrinkLinkContacts
SET DlContactsIsConfirmed = 1
WHERE 
DlContactOwnership = @userId

END
