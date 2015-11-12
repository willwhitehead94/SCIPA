USE [master]
GO
/****** Object:  Database [SCIPA]    Script Date: 12/11/2015 21:32:39 ******/
CREATE DATABASE [SCIPA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SCIPA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\SCIPA.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SCIPA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\SCIPA_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SCIPA] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SCIPA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SCIPA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SCIPA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SCIPA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SCIPA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SCIPA] SET ARITHABORT OFF 
GO
ALTER DATABASE [SCIPA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SCIPA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SCIPA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SCIPA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SCIPA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SCIPA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SCIPA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SCIPA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SCIPA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SCIPA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SCIPA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SCIPA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SCIPA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SCIPA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SCIPA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SCIPA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SCIPA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SCIPA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SCIPA] SET  MULTI_USER 
GO
ALTER DATABASE [SCIPA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SCIPA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SCIPA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SCIPA] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SCIPA] SET DELAYED_DURABILITY = DISABLED 
GO
USE [SCIPA]
GO
/****** Object:  Table [dbo].[Alarm]    Script Date: 12/11/2015 21:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alarm](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[deviceId] [int] NOT NULL,
	[alarmTypeId] [int] NOT NULL,
	[value] [nchar](500) NOT NULL,
 CONSTRAINT [PK_Alarm] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AlarmType]    Script Date: 12/11/2015 21:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlarmType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[alarmType] [nchar](50) NOT NULL,
 CONSTRAINT [PK_AlarmType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Command]    Script Date: 12/11/2015 21:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Command](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[deviceId] [int] NOT NULL,
	[commandTypeId] [int] NOT NULL,
	[communicatorId] [int] NOT NULL,
	[commandText] [nchar](1000) NOT NULL,
	[returnValueTypeId] [int] NOT NULL,
 CONSTRAINT [PK_Command] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CommandType]    Script Date: 12/11/2015 21:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommandType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[commandType] [nchar](25) NOT NULL,
 CONSTRAINT [PK_CommandType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Communicator]    Script Date: 12/11/2015 21:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Communicator](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[deviceId] [int] NOT NULL,
	[communicatorTypeId] [int] NOT NULL,
	[subId] [int] NOT NULL,
	[valueTypeId] [int] NOT NULL,
 CONSTRAINT [PK_Communicator] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CommunicatorType]    Script Date: 12/11/2015 21:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommunicatorType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[communicatorType] [nchar](25) NOT NULL,
 CONSTRAINT [PK_CommunicatorType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Device]    Script Date: 12/11/2015 21:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Device](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](20) NOT NULL,
	[readOnly] [bit] NOT NULL,
	[locationId] [int] NOT NULL,
	[faultTolerance] [real] NULL,
	[valueTypeId] [int] NOT NULL,
	[lowestValue] [int] NOT NULL,
	[highestValue] [int] NOT NULL,
 CONSTRAINT [PK_Device] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DeviceValue]    Script Date: 12/11/2015 21:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeviceValue](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[deviceId] [int] NOT NULL,
	[date] [date] NOT NULL,
	[time] [time](7) NULL,
	[value] [nchar](500) NULL,
	[withinTolerance] [bit] NOT NULL,
 CONSTRAINT [PK_DeviceValue] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FileCommunicator]    Script Date: 12/11/2015 21:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FileCommunicator](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[filePath] [varchar](max) NOT NULL,
	[startChar] [int] NOT NULL,
	[endChar] [int] NOT NULL,
	[openModeId] [int] NOT NULL,
 CONSTRAINT [PK_FileCommunicator] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FileOpenMode]    Script Date: 12/11/2015 21:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FileOpenMode](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[openMode] [nchar](10) NOT NULL,
 CONSTRAINT [PK_FileOpenMode] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Location]    Script Date: 12/11/2015 21:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](50) NOT NULL,
	[long] [real] NULL,
	[lat] [real] NULL,
	[notes] [nchar](2000) NULL,
 CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Rule]    Script Date: 12/11/2015 21:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rule](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[deviceId] [int] NOT NULL,
	[ruleText] [nchar](500) NOT NULL,
 CONSTRAINT [PK_Rule] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RuleCommandLookup]    Script Date: 12/11/2015 21:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RuleCommandLookup](
	[ruleId] [int] NOT NULL,
	[commandId] [int] NOT NULL,
 CONSTRAINT [PK_RuleCommandLookup] PRIMARY KEY CLUSTERED 
(
	[ruleId] ASC,
	[commandId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SerialCommunicator]    Script Date: 12/11/2015 21:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SerialCommunicator](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[comPort] [int] NOT NULL,
	[baudRate] [int] NOT NULL,
	[dataBits] [tinyint] NOT NULL,
	[isRTS] [bit] NULL,
	[isDTR] [bit] NULL,
 CONSTRAINT [PK_SerialCommunicator] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ValueType]    Script Date: 12/11/2015 21:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ValueType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type] [nchar](15) NOT NULL,
 CONSTRAINT [PK_ValueType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[RuleCommandTypeView]    Script Date: 12/11/2015 21:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[RuleCommandTypeView]
AS
SELECT        dbo.RuleCommandLookup.ruleId, dbo.RuleCommandLookup.commandId, dbo.Command.commandTypeId, dbo.CommandType.commandType
FROM            dbo.RuleCommandLookup INNER JOIN
                         dbo.Command ON dbo.RuleCommandLookup.commandId = dbo.Command.id INNER JOIN
                         dbo.CommandType ON dbo.Command.commandTypeId = dbo.CommandType.id

GO
ALTER TABLE [dbo].[Alarm]  WITH CHECK ADD  CONSTRAINT [FK_Alarm_Alarm] FOREIGN KEY([id])
REFERENCES [dbo].[Device] ([id])
GO
ALTER TABLE [dbo].[Alarm] CHECK CONSTRAINT [FK_Alarm_Alarm]
GO
ALTER TABLE [dbo].[Alarm]  WITH CHECK ADD  CONSTRAINT [FK_Alarm_AlarmType] FOREIGN KEY([alarmTypeId])
REFERENCES [dbo].[AlarmType] ([id])
GO
ALTER TABLE [dbo].[Alarm] CHECK CONSTRAINT [FK_Alarm_AlarmType]
GO
ALTER TABLE [dbo].[Command]  WITH CHECK ADD  CONSTRAINT [FK_Command_CommandType] FOREIGN KEY([commandTypeId])
REFERENCES [dbo].[CommandType] ([id])
GO
ALTER TABLE [dbo].[Command] CHECK CONSTRAINT [FK_Command_CommandType]
GO
ALTER TABLE [dbo].[Command]  WITH CHECK ADD  CONSTRAINT [FK_Command_Communicator] FOREIGN KEY([id])
REFERENCES [dbo].[Device] ([id])
GO
ALTER TABLE [dbo].[Command] CHECK CONSTRAINT [FK_Command_Communicator]
GO
ALTER TABLE [dbo].[Command]  WITH CHECK ADD  CONSTRAINT [FK_Command_Device] FOREIGN KEY([id])
REFERENCES [dbo].[Device] ([id])
GO
ALTER TABLE [dbo].[Command] CHECK CONSTRAINT [FK_Command_Device]
GO
ALTER TABLE [dbo].[Command]  WITH CHECK ADD  CONSTRAINT [FK_Command_ValueType] FOREIGN KEY([returnValueTypeId])
REFERENCES [dbo].[ValueType] ([id])
GO
ALTER TABLE [dbo].[Command] CHECK CONSTRAINT [FK_Command_ValueType]
GO
ALTER TABLE [dbo].[Communicator]  WITH CHECK ADD  CONSTRAINT [FK_Communicator_CommunicatorType] FOREIGN KEY([communicatorTypeId])
REFERENCES [dbo].[CommunicatorType] ([id])
GO
ALTER TABLE [dbo].[Communicator] CHECK CONSTRAINT [FK_Communicator_CommunicatorType]
GO
ALTER TABLE [dbo].[Communicator]  WITH CHECK ADD  CONSTRAINT [FK_Communicator_Device] FOREIGN KEY([deviceId])
REFERENCES [dbo].[Device] ([id])
GO
ALTER TABLE [dbo].[Communicator] CHECK CONSTRAINT [FK_Communicator_Device]
GO
ALTER TABLE [dbo].[Communicator]  WITH CHECK ADD  CONSTRAINT [FK_Communicator_ValueType] FOREIGN KEY([valueTypeId])
REFERENCES [dbo].[ValueType] ([id])
GO
ALTER TABLE [dbo].[Communicator] CHECK CONSTRAINT [FK_Communicator_ValueType]
GO
ALTER TABLE [dbo].[DeviceValue]  WITH CHECK ADD  CONSTRAINT [FK_DeviceValue_Device] FOREIGN KEY([deviceId])
REFERENCES [dbo].[Device] ([id])
GO
ALTER TABLE [dbo].[DeviceValue] CHECK CONSTRAINT [FK_DeviceValue_Device]
GO
ALTER TABLE [dbo].[FileCommunicator]  WITH CHECK ADD  CONSTRAINT [FK_FileCommunicator_FileOpenMode] FOREIGN KEY([openModeId])
REFERENCES [dbo].[FileOpenMode] ([id])
GO
ALTER TABLE [dbo].[FileCommunicator] CHECK CONSTRAINT [FK_FileCommunicator_FileOpenMode]
GO
ALTER TABLE [dbo].[Rule]  WITH CHECK ADD  CONSTRAINT [FK_Rule_Device] FOREIGN KEY([deviceId])
REFERENCES [dbo].[Device] ([id])
GO
ALTER TABLE [dbo].[Rule] CHECK CONSTRAINT [FK_Rule_Device]
GO
ALTER TABLE [dbo].[RuleCommandLookup]  WITH CHECK ADD  CONSTRAINT [FK_RuleCommandLookup_Command] FOREIGN KEY([commandId])
REFERENCES [dbo].[Command] ([id])
GO
ALTER TABLE [dbo].[RuleCommandLookup] CHECK CONSTRAINT [FK_RuleCommandLookup_Command]
GO
ALTER TABLE [dbo].[RuleCommandLookup]  WITH CHECK ADD  CONSTRAINT [FK_RuleCommandLookup_Rule] FOREIGN KEY([ruleId])
REFERENCES [dbo].[Rule] ([id])
GO
ALTER TABLE [dbo].[RuleCommandLookup] CHECK CONSTRAINT [FK_RuleCommandLookup_Rule]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "RuleCommandLookup"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 182
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CommandType"
            Begin Extent = 
               Top = 33
               Left = 591
               Bottom = 129
               Right = 761
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Command"
            Begin Extent = 
               Top = 17
               Left = 288
               Bottom = 147
               Right = 474
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1560
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1590
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'RuleCommandTypeView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'RuleCommandTypeView'
GO
USE [master]
GO
ALTER DATABASE [SCIPA] SET  READ_WRITE 
GO
