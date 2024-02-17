USE [book_manager]
GO

CREATE VIEW [dbo].[View_employees]
AS
SELECT
    employee_number,
    employee_password,
    first_name,
    editor
FROM
    dbo.employees
GO
