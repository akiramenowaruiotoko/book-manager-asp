USE [book_manager]
GO

/****** Object:  View [dbo].[View_employees]    Script Date: 2024/02/10 23:20:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_employees]
AS
SELECT        employee_number, employee_password, editor
FROM         dbo.employees
GO