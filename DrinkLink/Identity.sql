alter table [dbo].[DrinkLinkContacts]
add DlContactsIsConfirmed bit not null default 0


alter table [dbo].[DrinkLinkContacts] alter column DlContactsIsConfirmed int not null 