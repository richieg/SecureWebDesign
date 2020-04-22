﻿USE [DrinkLInk]
GO

/****** Object: SqlProcedure [dbo].[sp_Dl_ReturnAllOrderDetails] Script Date: 21/04/2020 11:02:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




ALTER PROC sp_Dl_ReturnAllOrderDetails @OrderId VARCHAR(50)
AS
BEGIN

SELECT DISTINCT
left(dlp.DlProductId,8) as DlOrderCurrentProductId, 
dlp.DlProductName as DlOrderCurrentProduct,
dlp.DlProductAvailableQUantity as DlOrderCurrentProductQuantity,
dlo.DlOrderQuantity as DlOrderCurrentQuantity, 
DlOrderDate as DlOrderDate


FROM
DrinkLinkOrder DLO
INNER JOIN DrinkLinkContacts dlc ON DLC.DlContactId = dlo.DlOrderCustomerId
INNER JOIN DrinkLinkProducts dlp on dlp.DlProductId = dlo.DlOrderProductId
WHERE DLO.dlOrderParentOrderId = @OrderId


END


     --public string DlOrderCurrentProductId { get; set; }
        --public string DlOrderCurrentProduct { get; set; }

        --public string DlOrderCurrentProductQuantity { get; set; }
        --public int DlOrderCurrentQuantity { get; set; }



        --public DateTime DlOrderDate { get; set; }