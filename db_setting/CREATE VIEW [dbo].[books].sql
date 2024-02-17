USE [book_manager]
GO

CREATE VIEW [dbo].[View_books]
AS
SELECT
    book_id,
    book_name
FROM
    dbo.books
GO
