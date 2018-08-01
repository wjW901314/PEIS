
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/31/2018 14:27:36
-- Generated from EDMX file: E:\Projects\HK.PEIS\HK.PEIS.Domain\Models\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PEIS];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TB_DEPARTMENTTB_USERS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_USERS] DROP CONSTRAINT [FK_TB_DEPARTMENTTB_USERS];
GO
IF OBJECT_ID(N'[dbo].[FK_TB_USERSTB_USERROLE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_USERROLE] DROP CONSTRAINT [FK_TB_USERSTB_USERROLE];
GO
IF OBJECT_ID(N'[dbo].[FK_TB_USERROLETB_ROLE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_USERROLE] DROP CONSTRAINT [FK_TB_USERROLETB_ROLE];
GO
IF OBJECT_ID(N'[dbo].[FK_TB_ROLETB_MENUROLE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_MENUROLE] DROP CONSTRAINT [FK_TB_ROLETB_MENUROLE];
GO
IF OBJECT_ID(N'[dbo].[FK_TB_MENUROLETB_MENU]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_MENUROLE] DROP CONSTRAINT [FK_TB_MENUROLETB_MENU];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[TB_DEPARTMENT]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_DEPARTMENT];
GO
IF OBJECT_ID(N'[dbo].[TB_USERS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_USERS];
GO
IF OBJECT_ID(N'[dbo].[TB_USERROLE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_USERROLE];
GO
IF OBJECT_ID(N'[dbo].[TB_ROLE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_ROLE];
GO
IF OBJECT_ID(N'[dbo].[TB_MENUROLE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_MENUROLE];
GO
IF OBJECT_ID(N'[dbo].[TB_MENU]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_MENU];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TB_DEPARTMENT'
CREATE TABLE [dbo].[TB_DEPARTMENT] (
    [DEPARTMENT_ID] int IDENTITY(1,1) NOT NULL,
    [DEPAREMENT_NAME] nvarchar(30)  NOT NULL,
    [PARENT_ID] int  NOT NULL,
    [DEPAREMENT_LEVEL] int  NOT NULL,
    [STATUS] int  NOT NULL
);
GO

-- Creating table 'TB_USERS'
CREATE TABLE [dbo].[TB_USERS] (
    [USER_ID] int IDENTITY(1,1) NOT NULL,
    [USER_NAME] nvarchar(30)  NOT NULL,
    [USER_PASSWORD] nvarchar(30)  NOT NULL,
    [FULLNAME] nvarchar(50)  NULL,
    [DEPARTMENT_ID] int  NOT NULL,
    [STATUS] int  NOT NULL,
    [CREATETIME] datetime  NOT NULL,
    [MODIFYTIME] datetime  NULL,
    [REMARK] nvarchar(100)  NULL
);
GO

-- Creating table 'TB_USERROLE'
CREATE TABLE [dbo].[TB_USERROLE] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [USER_ID] int  NOT NULL,
    [ROLE_ID] int  NOT NULL
);
GO

-- Creating table 'TB_ROLE'
CREATE TABLE [dbo].[TB_ROLE] (
    [ROLE_ID] int IDENTITY(1,1) NOT NULL,
    [ROLE_NAME] nvarchar(50)  NOT NULL,
    [DESCRIPTION] nvarchar(100)  NULL,
    [CREATETIME] datetime  NOT NULL,
    [MODIFYTIME] datetime  NULL,
    [ROLE_DEFAULTURL] nvarchar(100)  NOT NULL
);
GO

-- Creating table 'TB_MENUROLE'
CREATE TABLE [dbo].[TB_MENUROLE] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ROLE_ID] int  NOT NULL,
    [MENU_ID] int  NOT NULL,
    [ROLE_TYPE] int  NOT NULL,
    [BUTTON_ID] int  NOT NULL
);
GO

-- Creating table 'TB_MENU'
CREATE TABLE [dbo].[TB_MENU] (
    [MENU_ID] int IDENTITY(1,1) NOT NULL,
    [MENU_NAME] nvarchar(100)  NOT NULL,
    [MENU_URL] nvarchar(200)  NOT NULL,
    [PARENT_ID] int  NOT NULL,
    [MENU_LEVEL] int  NOT NULL,
    [STOP_ORDER] nvarchar(30)  NULL,
    [STATUS] int  NOT NULL,
    [REMARK] nvarchar(100)  NULL,
    [MENU_ICO] nvarchar(100)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [DEPARTMENT_ID] in table 'TB_DEPARTMENT'
ALTER TABLE [dbo].[TB_DEPARTMENT]
ADD CONSTRAINT [PK_TB_DEPARTMENT]
    PRIMARY KEY CLUSTERED ([DEPARTMENT_ID] ASC);
GO

-- Creating primary key on [USER_ID] in table 'TB_USERS'
ALTER TABLE [dbo].[TB_USERS]
ADD CONSTRAINT [PK_TB_USERS]
    PRIMARY KEY CLUSTERED ([USER_ID] ASC);
GO

-- Creating primary key on [ID] in table 'TB_USERROLE'
ALTER TABLE [dbo].[TB_USERROLE]
ADD CONSTRAINT [PK_TB_USERROLE]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ROLE_ID] in table 'TB_ROLE'
ALTER TABLE [dbo].[TB_ROLE]
ADD CONSTRAINT [PK_TB_ROLE]
    PRIMARY KEY CLUSTERED ([ROLE_ID] ASC);
GO

-- Creating primary key on [ID] in table 'TB_MENUROLE'
ALTER TABLE [dbo].[TB_MENUROLE]
ADD CONSTRAINT [PK_TB_MENUROLE]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [MENU_ID] in table 'TB_MENU'
ALTER TABLE [dbo].[TB_MENU]
ADD CONSTRAINT [PK_TB_MENU]
    PRIMARY KEY CLUSTERED ([MENU_ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DEPARTMENT_ID] in table 'TB_USERS'
ALTER TABLE [dbo].[TB_USERS]
ADD CONSTRAINT [FK_TB_DEPARTMENTTB_USERS]
    FOREIGN KEY ([DEPARTMENT_ID])
    REFERENCES [dbo].[TB_DEPARTMENT]
        ([DEPARTMENT_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TB_DEPARTMENTTB_USERS'
CREATE INDEX [IX_FK_TB_DEPARTMENTTB_USERS]
ON [dbo].[TB_USERS]
    ([DEPARTMENT_ID]);
GO

-- Creating foreign key on [USER_ID] in table 'TB_USERROLE'
ALTER TABLE [dbo].[TB_USERROLE]
ADD CONSTRAINT [FK_TB_USERSTB_USERROLE]
    FOREIGN KEY ([USER_ID])
    REFERENCES [dbo].[TB_USERS]
        ([USER_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TB_USERSTB_USERROLE'
CREATE INDEX [IX_FK_TB_USERSTB_USERROLE]
ON [dbo].[TB_USERROLE]
    ([USER_ID]);
GO

-- Creating foreign key on [ROLE_ID] in table 'TB_USERROLE'
ALTER TABLE [dbo].[TB_USERROLE]
ADD CONSTRAINT [FK_TB_USERROLETB_ROLE]
    FOREIGN KEY ([ROLE_ID])
    REFERENCES [dbo].[TB_ROLE]
        ([ROLE_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TB_USERROLETB_ROLE'
CREATE INDEX [IX_FK_TB_USERROLETB_ROLE]
ON [dbo].[TB_USERROLE]
    ([ROLE_ID]);
GO

-- Creating foreign key on [ROLE_ID] in table 'TB_MENUROLE'
ALTER TABLE [dbo].[TB_MENUROLE]
ADD CONSTRAINT [FK_TB_ROLETB_MENUROLE]
    FOREIGN KEY ([ROLE_ID])
    REFERENCES [dbo].[TB_ROLE]
        ([ROLE_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TB_ROLETB_MENUROLE'
CREATE INDEX [IX_FK_TB_ROLETB_MENUROLE]
ON [dbo].[TB_MENUROLE]
    ([ROLE_ID]);
GO

-- Creating foreign key on [MENU_ID] in table 'TB_MENUROLE'
ALTER TABLE [dbo].[TB_MENUROLE]
ADD CONSTRAINT [FK_TB_MENUROLETB_MENU]
    FOREIGN KEY ([MENU_ID])
    REFERENCES [dbo].[TB_MENU]
        ([MENU_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TB_MENUROLETB_MENU'
CREATE INDEX [IX_FK_TB_MENUROLETB_MENU]
ON [dbo].[TB_MENUROLE]
    ([MENU_ID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------