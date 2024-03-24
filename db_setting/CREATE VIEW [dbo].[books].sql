USE [book_manager]
GO

CREATE OR ALTER VIEW [dbo].[view_books]
AS
SELECT
    book_id,
    book_name
FROM
    dbo.books
GO
