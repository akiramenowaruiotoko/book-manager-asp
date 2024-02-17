USE [book_manager]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[books](
    [book_id] [char](10) NOT NULL,
    [book_name] [varchar](50) NOT NULL,
    CONSTRAINT [PK_books] PRIMARY KEY CLUSTERED 
    (
        [book_id] ASC
    )
    WITH (
        PAD_INDEX = OFF,
        STATISTICS_NORECOMPUTE = OFF,
        IGNORE_DUP_KEY = OFF,
        ALLOW_ROW_LOCKS = ON,
        ALLOW_PAGE_LOCKS = ON,
        OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
    )
) ON [PRIMARY]
GO
