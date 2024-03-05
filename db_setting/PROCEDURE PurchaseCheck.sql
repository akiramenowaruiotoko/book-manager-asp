USE [book_manager]
GO

CREATE OR ALTER PROCEDURE [dbo].[PurchaseCheck]
    @BookId CHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    -- 書籍が存在し、ステータスが０か確認
    IF EXISTS (SELECT 1 FROM statuses WHERE book_id = @BookId and status_num = 0)
		BEGIN
			-- 書籍が存在しステータスが０の場合はstatusesテーブルを更新、RETURN 0を返す
			UPDATE statuses set status_num = 1 where book_id = @BookId;
			RETURN 0;
		END
    ELSE
		BEGIN
			-- 書籍が存在しない場合は中止、RETURN -1を返す
			RETURN -1;
		END
END;