USE [book_manager]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[employees](
    [employee_number] [int] NOT NULL,
    [employee_password] [varchar](50) NOT NULL,
    [first_name] [varchar](50) NULL,
    [editor] [bit] NOT NULL,
    CONSTRAINT [PK_employees] PRIMARY KEY CLUSTERED 
    (
        [employee_number] ASC
    )
    WITH (
        PAD_INDEX = OFF, 
        STATISTICS_NORECOMPUTE = OFF, 
        IGNORE_DUP_KEY = OFF, 
        ALLOW_ROW_LOCKS = ON, 
        ALLOW_PAGE_LOCKS = ON, 
        OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
    ) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[employees] 
ADD CONSTRAINT [DF_employees_editor] DEFAULT ((0)) FOR [editor]
GO
