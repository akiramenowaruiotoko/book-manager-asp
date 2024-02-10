USE [book_manager]
GO

/****** Object:  View [dbo].[View_books]    Script Date: 2024/02/10 23:23:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_books]
AS
SELECT        book_id, book_name
FROM         dbo.books
GO