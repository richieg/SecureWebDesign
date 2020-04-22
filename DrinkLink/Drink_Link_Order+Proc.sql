--EXEC sp_Dl_ReturnAllOrders 1

ALTER PROC sp_Dl_ReturnAllOrders @Status Int
AS
BEGIN

SELECT 
left(dlp.DlProductId,8) as DlOrderCurrentProductId, dlp.DlProductName as DlOrderCurrentProduct,dlp.DlProductAvailableQUantity as DlOrderCurrentProductQuantity,
dlo.DlOrderQuantity as DlOrderCurrentQuantity, dlc.DlContactName as DlOrderCustomerNames,
dlc.DlContactAddressLine1 + ' ' + dlc.DlContactAddressLine2 + ' ' + dlc.DlContactAddressPostCode as DlOrderCustomerAddress,
DlOrderDate as DlOrderDate


FROM
DrinkLinkOrder DLO
INNER JOIN DrinkLinkContacts dlc ON DLC.DlContactId = dlo.DlOrderCustomerId
INNER JOIN DrinkLinkProducts dlp on dlp.DlProductId = dlo.DlOrderProductId
group by DLO.dlOrderParentOrderId,dlc.DlContactName,dlc.DlContactAddressLine1 , dlc.DlContactAddressLine2 , dlc.DlContactAddressPostCode,dlp.DlProductId,dlp.DlProductName,dlo.DlOrderQuantity,DlOrderDate,DlProductAvailableQUantity


END



        --public string DlOrderCurrentProductId { get; set; }
        --public string DlOrderCurrentProduct { get; set; }

        --public string DlOrderCurrentProductQuantity { get; set; }
        --public string DlOrderCurrentQuantity { get; set; }

        --public string DlOrderCustomerNames { get; set; }

        --public string DlOrderCustomerAddress { get; set; }

        --public DateTime DlOrderDate { get; set; }