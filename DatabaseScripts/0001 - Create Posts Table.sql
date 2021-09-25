USE [DatabaseFirstDemo]
GO

/****** Object:  Table [dbo].[Posts]    Script Date: 25/09/2021 16:26:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Posts](
	[PostID] [int] NOT NULL,
	[DatePublished] [smalldatetime] NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Body] [varchar](8000) NOT NULL,
) ON [PRIMARY]
GO

