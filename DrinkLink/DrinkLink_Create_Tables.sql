DROP TABLE DrinkLinkContacts

CREATE TABLE DrinkLinkContacts
(DlContactId NVARCHAR(50) NOT NULL UNIQUE,
DlContactOwnership NVARCHAR(50) NOT NULL,
DlContactName NVARCHAR(255) NOT NULL,
DlContactAddressLine1 NVARCHAR(255) NOT NULL,
DlContactAddressLine2 NVARCHAR(255) NOT NULL,
DlContactAddressLine3 NVARCHAR(255) NULL,
DlContactAddressPostCode NVARCHAR(15),
DlContactPhoneNumber INT,
DlContactEmail NVARCHAR(50) NOT NULL,
 CONSTRAINT [DlContact_PK] PRIMARY KEY
(
	DlContactEmail
)
)


DROP TABLE DrinkLinkProducts

CREATE TABLE DrinkLinkProducts
(DlProductId NVARCHAR(50) NOT NULL UNIQUE,
DlProductOwnership NVARCHAR(50) NOT NULL,
DlProductName NVARCHAR(255) NOT NULL,
DlProductDescription NVARCHAR(255) NOT NULL,
DlProductAvailableQUantity NVARCHAR(255) NOT NULL,

 CONSTRAINT [DlProduct_PK] PRIMARY KEY CLUSTERED
(
	DlProductName,DlProductAvailableQUantity
)
)

DROP TABLE DrinkLinkProductCategory

CREATE TABLE DrinkLinkProductCategory
(DlProductCategoryId NVARCHAR(50) NOT NULL UNIQUE,
DlProductCategoryName NVARCHAR(100) NOT NULL,
 CONSTRAINT [DlProductCategory_PK] PRIMARY KEY
(
	DlProductCategoryName
)
)

DROP TABLE DrinkLinkProductQuantity

CREATE TABLE DrinkLinkProductQuantity
(DlProductQuantityProductId NVARCHAR(50) NOT NULL UNIQUE,
DlProductQuantityUnits INT NOT NULL,
 CONSTRAINT DrinkLinkProductQuantity_PK PRIMARY KEY
(
	DlProductQuantityProductId
)
)

DROP TABLE DrinkLinkOrder

CREATE TABLE DrinkLinkOrder
(DlOrderId NVARCHAR(50) NOT NULL UNIQUE,
DlOrderProductId NVARCHAR(50) NOT NULL,
DlOrderCustomerId NVARCHAR(255) NOT NULL,
DlOrderQuantity NVARCHAR(255) NOT NULL,
DlOrderDate DATETIME,

 CONSTRAINT [DlOrder_PK] PRIMARY KEY CLUSTERED
(
	DlOrderId
)
)