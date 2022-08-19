if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Appointments]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Appointments]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Owners]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Owners]
GO

if not exists (select * from dbo.sysusers where name = N'WinSchedule' and uid < 16382)
	EXEC sp_grantdbaccess N'WinSchedule', N'WinSchedule'
GO

if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Appointments]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[Appointments] (
	[AppointmentID] [int] IDENTITY (1, 1) NOT NULL ,
	[AllProperties] [varbinary] (1024) NULL ,
	[StartDateTime] [datetime] NOT NULL ,
	[EndDateTime] [datetime] NOT NULL ,
	[Subject] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[AllDayEvent] [bit] NOT NULL ,
	[OwnerKey] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
END

GO

if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Owners]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[Owners] (
	[OwnerKey] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[AllProperties] [varbinary] (256) NULL ,
	[Name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Visible] [bit] NOT NULL 
) ON [PRIMARY]
END

GO

ALTER TABLE [dbo].[Appointments] WITH NOCHECK ADD 
	CONSTRAINT [PK_Appointments] PRIMARY KEY  CLUSTERED 
	(
		[AppointmentID]
	)  ON [PRIMARY] 
GO

