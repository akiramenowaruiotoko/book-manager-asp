USE [book_manager]
GO

/****** Object:  Table [dbo].[statuses]    Script Date: 2024/02/10 22:42:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[statuses](
	[status_id] [int] IDENTITY(1,1) NOT NULL,
	[book_id] [char](10) NOT NULL,
	[employee_number] [int] NOT NULL,
	[status_num] [int] NOT NULL,
	[rent_date] [date] NULL,
	[return_date] [date] NULL,
 CONSTRAINT [PK_statuses] PRIMARY KEY CLUSTERED 
(
	[status_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[statuses] ADD  CONSTRAINT [DF_Table_1_book_status]  DEFAULT ((0)) FOR [status_num]
GO

ALTER TABLE [dbo].[statuses]  WITH CHECK ADD  CONSTRAINT [FK_statuses_books] FOREIGN KEY([book_id])
REFERENCES [dbo].[books] ([book_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[statuses] CHECK CONSTRAINT [FK_statuses_books]
GO

ALTER TABLE [dbo].[statuses]  WITH CHECK ADD  CONSTRAINT [FK_statuses_employees] FOREIGN KEY([employee_number])
REFERENCES [dbo].[employees] ([employee_number])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[statuses] CHECK CONSTRAINT [FK_statuses_employees]
GO

