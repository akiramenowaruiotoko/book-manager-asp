USE [book_manager]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[view_all]
AS
SELECT
    b.book_id,
    b.book_name,
    e.employee_number,
    e.first_name,
    s.status_id,
    s.status_num,
    s.rent_date,
    s.return_date
FROM
    books AS b
LEFT JOIN
    statuses AS s ON b.book_id = s.book_id
LEFT JOIN
    employees AS e ON s.employee_number = e.employee_number;
GO
