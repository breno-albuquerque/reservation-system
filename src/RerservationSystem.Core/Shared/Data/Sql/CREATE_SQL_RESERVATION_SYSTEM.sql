-- DATABASE SQL_RESERVATION_SYSTEM
USE [master]

CREATE DATABASE [SQL_RESERVATION_SYSTEM]
GO

USE [SQL_RESERVATION_SYSTEM]
GO

-- ROLE
CREATE TABLE [ROLE](
	[ID] int not null unique identity,
	[ROLE_NAME] nvarchar(50) not null unique,
	[DATE_INSERTION] datetime not null, 
	[DATE_ALTERATION] datetime not null,
	constraint [PK_ROLE] primary key ([id])
)
GO

--	USER
CREATE TABLE [USER](
	[ID] int not null unique identity,
	[USER_ROLE] int not null,
	[DOCUMENT] char(11) not null unique,
	[EMAIL] nvarchar(100) not null unique,
	[PASSWORD] nvarchar(100) not null,
	[DATE_INSERTION] datetime not null, 
	[DATE_ALTERATION] datetime not null,
	constraint [PK_USER] primary key ([ID]),
	constraint [FK_ROLE] foreign key ([USER_ROLE]) references [ROLE] ([ID])
)
GO

--	PRODUCT_TYPE
CREATE TABLE [PRODUCT_TYPE](
	[ID] int not null unique identity,
	[TYPE_NAME] nvarchar(50) not null unique,
	[DATE_INSERTION] datetime not null, 
	[DATE_ALTERATION] datetime not null,
	constraint PK_PRODUCT_TYPE primary key ([ID]),
)
GO

--	PRODUCT
CREATE TABLE [PRODUCT](
	[ID] int not null unique identity,
	[PRODUCT_TYPE] int not null,
	[CAPACITY] int not null,
	[NAME] nvarchar(100) not null,
	[DATE_INSERTION] datetime not null, 
	[DATE_ALTERATION] datetime not null,
	constraint [PK_PRODUCT] primary key ([ID]),
	constraint [FK_PRODUCT_TYPE] foreign key ([PRODUCT_TYPE]) references [PRODUCT_TYPE] ([ID])
)
GO

--	RESERVATION
CREATE TABLE [RESERVATION](
	[ID] int not null unique identity,
	[USER] int not null,
	[PRODUCT] int not null,
	[DATE_BEGIN] datetime not null,
	[DATE_END] datetime not null,
	[DATE_INSERTION] datetime not null, 
	[DATE_ALTERATION] datetime not null,
	constraint [PK_RESERVATION] primary key ([ID]),
	constraint [FK_USER] foreign key ([USER]) references [USER] ([ID]),
	constraint [FK_PRODUCT] foreign key ([PRODUCT]) references [PRODUCT] ([ID]),
)
GO

--	PAYMENT
CREATE TABLE [PAYMENT](
	[ID] int not null unique identity,
	[RESERVATION] int not null,
	[METHOD] nvarchar(50) not null,
	[VALUE] money not null, 
	constraint [ID] primary key ([ID]),
	constraint [FK_RESERVATION] foreign key ([RESERVATION]) references [RESERVATION] ([ID])
)
GO
