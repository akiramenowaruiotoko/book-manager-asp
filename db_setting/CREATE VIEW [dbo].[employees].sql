USE [book_manager]
GO

/****** Object:  View [dbo].[View_employees]    Script Date: 2024/03/09 11:26:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE OR ALTER VIEW [dbo].[View_employees]
AS
SELECT
    employee_number,
    employee_password,
    first_name,
    editor
FROM
    dbo.employees
GO


