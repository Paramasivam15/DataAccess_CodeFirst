USE [db_the_recs]
GO
/****** Object:  Table [dbo].[tb_the_recs]    Script Date: 03/25/2018 14:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_the_recs]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_the_recs](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[rec] [varchar](50) NULL,
 CONSTRAINT [PK_tb_the_recs] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_the_comments]    Script Date: 03/25/2018 14:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_the_comments]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_the_comments](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[rec_the_Id] [bigint] NOT NULL,
	[comments] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tb_the_comments] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_tb_the_comments_tb_the_recs]    Script Date: 03/25/2018 14:09:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_the_comments_tb_the_recs]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_the_comments]'))
ALTER TABLE [dbo].[tb_the_comments]  WITH CHECK ADD  CONSTRAINT [FK_tb_the_comments_tb_the_recs] FOREIGN KEY([rec_the_Id])
REFERENCES [dbo].[tb_the_recs] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_the_comments_tb_the_recs]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_the_comments]'))
ALTER TABLE [dbo].[tb_the_comments] CHECK CONSTRAINT [FK_tb_the_comments_tb_the_recs]
GO
