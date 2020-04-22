USE [DrinkLInk]
GO

/****** Object: Table [dbo].[DrinkLinkOrder] Script Date: 21/04/2020 11:46:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DrinkLinkOrderStatus] (
    [DlOrderStatusId]            INT IDENTITY NOT NULL,
    [DlOrderStatusOrderId]     NVARCHAR (50) PRIMARY KEY  NOT NULL,
    [DlOrderStatusStatus]    INT NOT NULL DEFAULT 0,

);


