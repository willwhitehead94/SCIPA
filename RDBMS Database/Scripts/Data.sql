USE [SCIPA]
GO
SET IDENTITY_INSERT [dbo].[ValueType] ON 

INSERT [dbo].[ValueType] ([id], [type]) VALUES (1, N'String         ')
INSERT [dbo].[ValueType] ([id], [type]) VALUES (2, N'Integer        ')
INSERT [dbo].[ValueType] ([id], [type]) VALUES (3, N'Real           ')
INSERT [dbo].[ValueType] ([id], [type]) VALUES (4, N'Boolean        ')
SET IDENTITY_INSERT [dbo].[ValueType] OFF
SET IDENTITY_INSERT [dbo].[CommunicatorType] ON 

INSERT [dbo].[CommunicatorType] ([id], [communicatorType]) VALUES (1, N'Database                 ')
INSERT [dbo].[CommunicatorType] ([id], [communicatorType]) VALUES (2, N'Serial                   ')
INSERT [dbo].[CommunicatorType] ([id], [communicatorType]) VALUES (3, N'File                     ')
SET IDENTITY_INSERT [dbo].[CommunicatorType] OFF
SET IDENTITY_INSERT [dbo].[CommandType] ON 

INSERT [dbo].[CommandType] ([id], [commandType]) VALUES (1, N'True                     ')
INSERT [dbo].[CommandType] ([id], [commandType]) VALUES (2, N'False                    ')
INSERT [dbo].[CommandType] ([id], [commandType]) VALUES (3, N'Okay                     ')
INSERT [dbo].[CommandType] ([id], [commandType]) VALUES (4, N'Failed                   ')
INSERT [dbo].[CommandType] ([id], [commandType]) VALUES (5, N'NoChange                 ')
INSERT [dbo].[CommandType] ([id], [commandType]) VALUES (6, N'Other                    ')
SET IDENTITY_INSERT [dbo].[CommandType] OFF
SET IDENTITY_INSERT [dbo].[AlarmType] ON 

INSERT [dbo].[AlarmType] ([id], [alarmType]) VALUES (1, N'CriticalLow                                       ')
INSERT [dbo].[AlarmType] ([id], [alarmType]) VALUES (2, N'LowLow                                            ')
INSERT [dbo].[AlarmType] ([id], [alarmType]) VALUES (3, N'Low                                               ')
INSERT [dbo].[AlarmType] ([id], [alarmType]) VALUES (4, N'Abnormal                                          ')
INSERT [dbo].[AlarmType] ([id], [alarmType]) VALUES (5, N'High                                              ')
INSERT [dbo].[AlarmType] ([id], [alarmType]) VALUES (6, N'HighHigh                                          ')
INSERT [dbo].[AlarmType] ([id], [alarmType]) VALUES (7, N'CritialHigh                                       ')
INSERT [dbo].[AlarmType] ([id], [alarmType]) VALUES (8, N'Invalid                                           ')
INSERT [dbo].[AlarmType] ([id], [alarmType]) VALUES (9, N'Unknown                                           ')
INSERT [dbo].[AlarmType] ([id], [alarmType]) VALUES (10, N'Other                                             ')
SET IDENTITY_INSERT [dbo].[AlarmType] OFF
SET IDENTITY_INSERT [dbo].[FileOpenMode] ON 

INSERT [dbo].[FileOpenMode] ([id], [openMode]) VALUES (1, N'ReadOnly  ')
INSERT [dbo].[FileOpenMode] ([id], [openMode]) VALUES (2, N'ReadWrite ')
INSERT [dbo].[FileOpenMode] ([id], [openMode]) VALUES (3, N'Admin     ')
SET IDENTITY_INSERT [dbo].[FileOpenMode] OFF
