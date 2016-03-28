
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/28/2016 17:36:05
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

IF OBJECT_ID(N'[dbo].[FK_DeviceCommunicators]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Communicators] DROP CONSTRAINT [FK_DeviceCommunicators];
GO
IF OBJECT_ID(N'[dbo].[FK_DeviceRule]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Rules] DROP CONSTRAINT [FK_DeviceRule];
GO
IF OBJECT_ID(N'[dbo].[FK_RuleAction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Actions] DROP CONSTRAINT [FK_RuleAction];
GO
IF OBJECT_ID(N'[dbo].[FK_ActionCommunicator]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Actions] DROP CONSTRAINT [FK_ActionCommunicator];
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
IF OBJECT_ID(N'[dbo].[Alarms]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Alarms];
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
    [RuleId] int  NOT NULL,
    [CommunicatorId] int  NOT NULL,
    [Enabled] bit  NOT NULL,
    [Rule_Id] int  NULL
);
GO

-- Creating table 'Communicators'
CREATE TABLE [dbo].[Communicators] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StartChar] int  NOT NULL,
    [EndChar] int  NOT NULL,
    [LastReadTime] datetime  NOT NULL,
    [Type] smallint  NOT NULL,
    [ValueType] smallint  NOT NULL,
    [Inbound] bit  NOT NULL,
    [Device_Id] int  NOT NULL,
    [Action_Id] int  NULL
);
GO

-- Creating table 'Devices'
CREATE TABLE [dbo].[Devices] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [Custodian] nvarchar(max)  NOT NULL,
    [Enabled] bit  NOT NULL
);
GO

-- Creating table 'Rules'
CREATE TABLE [dbo].[Rules] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DeviceId] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [ValueType] smallint  NOT NULL,
    [RuleType] smallint  NOT NULL,
    [Constraint] nvarchar(max)  NOT NULL,
    [Alarm] bit  NOT NULL
);
GO

-- Creating table 'Values'
CREATE TABLE [dbo].[Values] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EventTime] datetime  NOT NULL,
    [Inbound] bit  NOT NULL,
    [Type] smallint  NOT NULL,
    [DeviceId] int  NOT NULL,
    [CommunicatorId] int  NOT NULL,
    [IntegerValue] int  NOT NULL,
    [FloatValue] decimal(18,0)  NOT NULL,
    [BooleanValue] bit  NOT NULL,
    [StringValue] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AppData'
CREATE TABLE [dbo].[AppData] (
    [BusinessName] nvarchar(max)  NOT NULL,
    [Supervisor] nvarchar(max)  NOT NULL,
    [Enabled] bit  NOT NULL,
    [Instance] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Alarms'
CREATE TABLE [dbo].[Alarms] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TimeStamp] datetime  NOT NULL,
    [DeviceId] int  NOT NULL,
    [ValueId] int  NOT NULL,
    [RuleId] int  NOT NULL,
    [Accepted] bit  NOT NULL
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
    [BaudRate] int  NOT NULL,
    [DataBits] tinyint  NOT NULL,
    [IsRTS] bit  NOT NULL,
    [IsDTR] bit  NOT NULL,
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

-- Creating primary key on [Id] in table 'Alarms'
ALTER TABLE [dbo].[Alarms]
ADD CONSTRAINT [PK_Alarms]
    PRIMARY KEY CLUSTERED ([Id] ASC);
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

-- Creating foreign key on [Device_Id] in table 'Communicators'
ALTER TABLE [dbo].[Communicators]
ADD CONSTRAINT [FK_DeviceCommunicators]
    FOREIGN KEY ([Device_Id])
    REFERENCES [dbo].[Devices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeviceCommunicators'
CREATE INDEX [IX_FK_DeviceCommunicators]
ON [dbo].[Communicators]
    ([Device_Id]);
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

-- Creating foreign key on [Rule_Id] in table 'Actions'
ALTER TABLE [dbo].[Actions]
ADD CONSTRAINT [FK_RuleAction]
    FOREIGN KEY ([Rule_Id])
    REFERENCES [dbo].[Rules]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RuleAction'
CREATE INDEX [IX_FK_RuleAction]
ON [dbo].[Actions]
    ([Rule_Id]);
GO

-- Creating foreign key on [Action_Id] in table 'Communicators'
ALTER TABLE [dbo].[Communicators]
ADD CONSTRAINT [FK_ActionCommunicator]
    FOREIGN KEY ([Action_Id])
    REFERENCES [dbo].[Actions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ActionCommunicator'
CREATE INDEX [IX_FK_ActionCommunicator]
ON [dbo].[Communicators]
    ([Action_Id]);
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