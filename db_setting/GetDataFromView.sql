USE [book_manager]
GO

DECLARE @RC int
DECLARE @ViewName nvarchar(100)

-- TODO: Set parameter values here.

EXECUTE @RC = [dbo].[GetDataFromView] 
   @ViewName
GO

