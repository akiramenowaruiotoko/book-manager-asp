USE [book_manager]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE OR ALTER VIEW [dbo].[view_employees]
AS
SELECT
    employee_number,
    employee_password,
    first_name,
    editor
FROM
    dbo.employees
GO


