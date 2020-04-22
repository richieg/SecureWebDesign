USE [DrinkLInk]
GO

/****** Object: SqlProcedure [dbo].[sp_Dl_ReturnAllOrders] Script Date: 21/04/2020 11:03:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER PROC sp_Dl_ReturnAllOrders @Status Int
AS
BEGIN

SELECT DISTINCT
dlOrderParentOrderId as DlOrderId,
dlc.DlContactName as DlOrderCustomerNames,
dlc.DlContactAddressLine1 + ' ' + dlc.DlContactAddressLine2 + ' ' + dlc.DlContactAddressPostCode as DlOrderCustomerAddress,
CAST(DlOrderDate AS DATE) as DlOrderDate


FROM
DrinkLinkOrder DLO
INNER JOIN DrinkLinkContacts dlc ON DLC.DlContactId = dlo.DlOrderCustomerId
INNER JOIN DrinkLinkProducts dlp on dlp.DlProductId = dlo.DlOrderProductId
group by DLO.dlOrderParentOrderId,dlc.DlContactName,dlc.DlContactAddressLine1 , dlc.DlContactAddressLine2 , dlc.DlContactAddressPostCode,CAST(dlo.DlOrderDate AS DATE)


END


   