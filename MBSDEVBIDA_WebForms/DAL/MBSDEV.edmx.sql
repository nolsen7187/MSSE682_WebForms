
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 10/30/2013 14:06:05
-- Generated from EDMX file: C:\Users\nolsen\Source\Repos\MBSDEVBIDA_WebForms\DAL\MBSDEV.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MBSDEVBIDA];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CUSTINVOICEJOUR]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CUSTINVOICEJOUR];
GO
IF OBJECT_ID(N'[dbo].[CUSTINVOICETRANS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CUSTINVOICETRANS];
GO
IF OBJECT_ID(N'[dbo].[CUSTTABLE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CUSTTABLE];
GO
IF OBJECT_ID(N'[dbo].[DATAAREA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DATAAREA];
GO
IF OBJECT_ID(N'[dbo].[MBSBDSALESREPTABLE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MBSBDSALESREPTABLE];
GO
IF OBJECT_ID(N'[dbo].[MBSWBWEBUSERCONTACT]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MBSWBWEBUSERCONTACT];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CUSTINVOICEJOURs'
CREATE TABLE [dbo].[CUSTINVOICEJOURs] (
    [SALESID] nvarchar(20)  NOT NULL,
    [ORDERACCOUNT] nvarchar(20)  NOT NULL,
    [INVOICEDATE] datetime  NOT NULL,
    [SALESBALANCE] decimal(28,12)  NOT NULL,
    [INVOICEAMOUNT] decimal(28,12)  NOT NULL,
    [INVOICEID] nvarchar(20)  NOT NULL,
    [SUMTAX] decimal(28,12)  NOT NULL,
    [MBSPRIMARYSALESREP] nvarchar(10)  NOT NULL,
    [DATAAREAID] nvarchar(4)  NOT NULL,
    [RECID] bigint  NOT NULL
);
GO

-- Creating table 'CUSTINVOICETRANS'
CREATE TABLE [dbo].[CUSTINVOICETRANS] (
    [INVOICEID] nvarchar(20)  NOT NULL,
    [INVOICEDATE] datetime  NOT NULL,
    [INVENTTRANSID] nvarchar(20)  NOT NULL,
    [ITEMID] nvarchar(20)  NOT NULL,
    [NAME] nvarchar(1000)  NOT NULL,
    [QTY] decimal(28,12)  NOT NULL,
    [SALESPRICE] decimal(28,12)  NOT NULL,
    [LINEAMOUNT] decimal(28,12)  NOT NULL,
    [DATAAREAID] nvarchar(4)  NOT NULL,
    [RECID] bigint  NOT NULL
);
GO

-- Creating table 'CUSTTABLEs'
CREATE TABLE [dbo].[CUSTTABLEs] (
    [ACCOUNTNUM] nvarchar(20)  NOT NULL,
    [NAME] nvarchar(60)  NOT NULL,
    [PHONE] nvarchar(20)  NOT NULL,
    [ZIPCODE] nvarchar(10)  NOT NULL,
    [STATE] nvarchar(10)  NOT NULL,
    [EMAIL] nvarchar(80)  NOT NULL,
    [CITY] nvarchar(60)  NOT NULL,
    [STREET] nvarchar(250)  NOT NULL,
    [MBSDEPARTMENTCODE] nvarchar(20)  NOT NULL,
    [DATAAREAID] nvarchar(4)  NOT NULL,
    [RECID] bigint  NOT NULL
);
GO

-- Creating table 'DATAAREAs'
CREATE TABLE [dbo].[DATAAREAs] (
    [ID] nvarchar(4)  NOT NULL,
    [NAME] nvarchar(40)  NOT NULL,
    [RECID] bigint  NOT NULL
);
GO

-- Creating table 'MBSBDSALESREPTABLEs'
CREATE TABLE [dbo].[MBSBDSALESREPTABLEs] (
    [SALESREPID] nvarchar(10)  NOT NULL,
    [NAME] nvarchar(60)  NOT NULL,
    [DATAAREAID] nvarchar(4)  NOT NULL,
    [RECID] bigint  NOT NULL
);
GO

-- Creating table 'MBSWBWEBUSERCONTACTs'
CREATE TABLE [dbo].[MBSWBWEBUSERCONTACTs] (
    [ACCOUNTNUM] nvarchar(20)  NOT NULL,
    [NAME] nvarchar(60)  NOT NULL,
    [EMAIL] nvarchar(80)  NOT NULL,
    [WEBLOGON] nvarchar(100)  NOT NULL,
    [WEBPASSWORD] nvarchar(20)  NOT NULL,
    [CONTACTPERSONID] nvarchar(20)  NOT NULL,
    [SALESREPID] nvarchar(10)  NOT NULL,
    [DATAAREAID] nvarchar(4)  NOT NULL,
    [RECID] bigint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [DATAAREAID], [RECID] in table 'CUSTINVOICEJOURs'
ALTER TABLE [dbo].[CUSTINVOICEJOURs]
ADD CONSTRAINT [PK_CUSTINVOICEJOURs]
    PRIMARY KEY CLUSTERED ([DATAAREAID], [RECID] ASC);
GO

-- Creating primary key on [DATAAREAID], [RECID] in table 'CUSTINVOICETRANS'
ALTER TABLE [dbo].[CUSTINVOICETRANS]
ADD CONSTRAINT [PK_CUSTINVOICETRANS]
    PRIMARY KEY CLUSTERED ([DATAAREAID], [RECID] ASC);
GO

-- Creating primary key on [ACCOUNTNUM], [DATAAREAID] in table 'CUSTTABLEs'
ALTER TABLE [dbo].[CUSTTABLEs]
ADD CONSTRAINT [PK_CUSTTABLEs]
    PRIMARY KEY CLUSTERED ([ACCOUNTNUM], [DATAAREAID] ASC);
GO

-- Creating primary key on [ID] in table 'DATAAREAs'
ALTER TABLE [dbo].[DATAAREAs]
ADD CONSTRAINT [PK_DATAAREAs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [SALESREPID], [DATAAREAID] in table 'MBSBDSALESREPTABLEs'
ALTER TABLE [dbo].[MBSBDSALESREPTABLEs]
ADD CONSTRAINT [PK_MBSBDSALESREPTABLEs]
    PRIMARY KEY CLUSTERED ([SALESREPID], [DATAAREAID] ASC);
GO

-- Creating primary key on [WEBLOGON], [CONTACTPERSONID], [DATAAREAID] in table 'MBSWBWEBUSERCONTACTs'
ALTER TABLE [dbo].[MBSWBWEBUSERCONTACTs]
ADD CONSTRAINT [PK_MBSWBWEBUSERCONTACTs]
    PRIMARY KEY CLUSTERED ([WEBLOGON], [CONTACTPERSONID], [DATAAREAID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------