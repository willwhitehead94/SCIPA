
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/21/2016 18:17:19
-- Generated from EDMX file: C:\Users\Will Whitehead\Dropbox\University\Year 4\Computing Project\SCIPA\SCIPA.Data.AccessLayer\DataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SCIPA];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_DeviceAction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Actions] DROP CONSTRAINT [FK_DeviceAction];
GO
IF OBJECT_ID(N'[dbo].[FK_DeviceCommunicator_Write]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Devices] DROP CONSTRAINT [FK_DeviceCommunicator_Write];
GO
IF OBJECT_ID(N'[dbo].[FK_DeviceCommunicator_Read]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Devices] DROP CONSTRAINT [FK_DeviceCommunicator_Read];
GO
IF OBJECT_ID(N'[dbo].[FK_DeviceRule]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Rules] DROP CONSTRAINT [FK_DeviceRule];
GO
IF OBJECT_ID(N'[dbo].[FK_DeviceValue]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Values] DROP CONSTRAINT [FK_DeviceValue];
GO
IF OBJECT_ID(N'[dbo].[FK_FileCommunicator_inherits_Communicator]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Communicators_FileCommunicator] DROP CONSTRAINT [FK_FileCommunicator_inherits_Communicator];
GO
IF OBJECT_ID(N'[dbo].[FK_SerialCommunicator_inherits_Communicator]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Communicators_SerialCommunicator] DROP CONSTRAINT [FK_SerialCommunicator_inherits_Communicator];
GO
IF OBJECT_ID(N'[dbo].[FK_DatabaseCommunicator_inherits_Communicator]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Communicators_DatabaseCommunicator] DROP CONSTRAINT [FK_DatabaseCommunicator_inherits_Communicator];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Actions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Actions];
GO
IF OBJECT_ID(N'[dbo].[Communicators]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Communicators];
GO
IF OBJECT_ID(N'[dbo].[Devices]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Devices];
GO
IF OBJECT_ID(N'[dbo].[Rules]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Rules];
GO
IF OBJECT_ID(N'[dbo].[Values]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Values];
GO
IF OBJECT_ID(N'[dbo].[AppData]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AppData];
GO
IF OBJECT_ID(N'[dbo].[Communicators_FileCommunicator]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Communicators_FileCommunicator];
GO
IF OBJECT_ID(N'[dbo].[Communicators_SerialCommunicator]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Communicators_SerialCommunicator];
GO
IF OBJECT_ID(N'[dbo].[Communicators_DatabaseCommunicator]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Communicators_DatabaseCommunicator];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Actions'
CREATE TABLE [dbo].[Actions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [OutputValue] nvarchar(max)  NOT NULL,
    [DeviceId] int  NOT NULL
);
GO

-- Creating table 'Communicators'
CREATE TABLE [dbo].[Communicators] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StartChar] nvarchar(max)  NOT NULL,
    [EndChar] nvarchar(max)  NOT NULL,
    [LastReadTime] nvarchar(max)  NOT NULL,
    [Type] smallint  NOT NULL
);
GO

-- Creating table 'Devices'
CREATE TABLE [dbo].[Devices] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [Custodian] nvarchar(max)  NOT NULL,
    [Enabled] bit  NOT NULL,
    [InboundValues] nvarchar(max)  NOT NULL,
    [OutboundValues] nvarchar(max)  NOT NULL,
    [Writer_Id] int  NOT NULL,
    [Reader_Id] int  NOT NULL
);
GO

-- Creating table 'Rules'
CREATE TABLE [dbo].[Rules] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DeviceId] int  NOT NULL,
    [Type] smallint  NOT NULL
);
GO

-- Creating table 'Values'
CREATE TABLE [dbo].[Values] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EventTime] nvarchar(max)  NOT NULL,
    [StringValue] nvarchar(max)  NOT NULL,
    [Inbound] nvarchar(max)  NOT NULL,
    [DeviceId] int  NOT NULL,
    [Type] smallint  NOT NULL
);
GO

-- Creating table 'AppData'
CREATE TABLE [dbo].[AppData] (
    [BusinessName] nvarchar(max)  NOT NULL,
    [Supervisor] nvarchar(max)  NOT NULL,
    [Enabled] nvarchar(max)  NOT NULL,
    [Instance] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Communicators_FileCommunicator'
CREATE TABLE [dbo].[Communicators_FileCommunicator] (
    [FilePath] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Communicators_SerialCommunicator'
CREATE TABLE [dbo].[Communicators_SerialCommunicator] (
    [ComPort] nvarchar(max)  NOT NULL,
    [BaudRate] nvarchar(max)  NOT NULL,
    [DataBits] nvarchar(max)  NOT NULL,
    [IsRTS] nvarchar(max)  NOT NULL,
    [IsDTR] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Communicators_DatabaseCommunicator'
CREATE TABLE [dbo].[Communicators_DatabaseCommunicator] (
    [ConnectionString] nvarchar(max)  NOT NULL,
    [Query] nvarchar(max)  NOT NULL,
    [DbType] smallint  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Actions'
ALTER TABLE [dbo].[Actions]
ADD CONSTRAINT [PK_Actions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Communicators'
ALTER TABLE [dbo].[Communicators]
ADD CONSTRAINT [PK_Communicators]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Devices'
ALTER TABLE [dbo].[Devices]
ADD CONSTRAINT [PK_Devices]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Rules'
ALTER TABLE [dbo].[Rules]
ADD CONSTRAINT [PK_Rules]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Values'
ALTER TABLE [dbo].[Values]
ADD CONSTRAINT [PK_Values]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Instance] in table 'AppData'
ALTER TABLE [dbo].[AppData]
ADD CONSTRAINT [PK_AppData]
    PRIMARY KEY CLUSTERED ([Instance] ASC);
GO

-- Creating primary key on [Id] in table 'Communicators_FileCommunicator'
ALTER TABLE [dbo].[Communicators_FileCommunicator]
ADD CONSTRAINT [PK_Communicators_FileCommunicator]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Communicators_SerialCommunicator'
ALTER TABLE [dbo].[Communicators_SerialCommunicator]
ADD CONSTRAINT [PK_Communicators_SerialCommunicator]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Communicators_DatabaseCommunicator'
ALTER TABLE [dbo].[Communicators_DatabaseCommunicator]
ADD CONSTRAINT [PK_Communicators_DatabaseCommunicator]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DeviceId] in table 'Actions'
ALTER TABLE [dbo].[Actions]
ADD CONSTRAINT [FK_DeviceAction]
    FOREIGN KEY ([DeviceId])
    REFERENCES [dbo].[Devices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeviceAction'
CREATE INDEX [IX_FK_DeviceAction]
ON [dbo].[Actions]
    ([DeviceId]);
GO

-- Creating foreign key on [Writer_Id] in table 'Devices'
ALTER TABLE [dbo].[Devices]
ADD CONSTRAINT [FK_DeviceCommunicator_Write]
    FOREIGN KEY ([Writer_Id])
    REFERENCES [dbo].[Communicators]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeviceCommunicator_Write'
CREATE INDEX [IX_FK_DeviceCommunicator_Write]
ON [dbo].[Devices]
    ([Writer_Id]);
GO

-- Creating foreign key on [Reader_Id] in table 'Devices'
ALTER TABLE [dbo].[Devices]
ADD CONSTRAINT [FK_DeviceCommunicator_Read]
    FOREIGN KEY ([Reader_Id])
    REFERENCES [dbo].[Communicators]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeviceCommunicator_Read'
CREATE INDEX [IX_FK_DeviceCommunicator_Read]
ON [dbo].[Devices]
    ([Reader_Id]);
GO

-- Creating foreign key on [DeviceId] in table 'Rules'
ALTER TABLE [dbo].[Rules]
ADD CONSTRAINT [FK_DeviceRule]
    FOREIGN KEY ([DeviceId])
    REFERENCES [dbo].[Devices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeviceRule'
CREATE INDEX [IX_FK_DeviceRule]
ON [dbo].[Rules]
    ([DeviceId]);
GO

-- Creating foreign key on [DeviceId] in table 'Values'
ALTER TABLE [dbo].[Values]
ADD CONSTRAINT [FK_DeviceValue]
    FOREIGN KEY ([DeviceId])
    REFERENCES [dbo].[Devices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeviceValue'
CREATE INDEX [IX_FK_DeviceValue]
ON [dbo].[Values]
    ([DeviceId]);
GO

-- Creating foreign key on [Id] in table 'Communicators_FileCommunicator'
ALTER TABLE [dbo].[Communicators_FileCommunicator]
ADD CONSTRAINT [FK_FileCommunicator_inherits_Communicator]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Communicators]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Communicators_SerialCommunicator'
ALTER TABLE [dbo].[Communicators_SerialCommunicator]
ADD CONSTRAINT [FK_SerialCommunicator_inherits_Communicator]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Communicators]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Communicators_DatabaseCommunicator'
ALTER TABLE [dbo].[Communicators_DatabaseCommunicator]
ADD CONSTRAINT [FK_DatabaseCommunicator_inherits_Communicator]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Communicators]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------