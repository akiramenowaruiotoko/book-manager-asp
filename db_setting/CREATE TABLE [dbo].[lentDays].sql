USE [book_manager]
GO

/****** Object:  Table [dbo].[lentDays]    Script Date: 2024/02/01 23:34:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[lentDays](
	[status_Id] [int] NOT NULL,
	[lent_day] [date] NOT NULL,
	[return_day] [date] NOT NULL,
 CONSTRAINT [PK_lentDays] PRIMARY KEY CLUSTERED 
(
	[status_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[lentDays]  WITH CHECK ADD  CONSTRAINT [FK_statuses_lentDays] FOREIGN KEY([status_Id])
REFERENCES [dbo].[statuses] ([status_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[lentDays] CHECK CONSTRAINT [FK_statuses_lentDays]
GO

