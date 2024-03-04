USE [book_manager]
GO

CREATE OR ALTER PROCEDURE [dbo].[PurchaseCheck]
    @BookId CHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    -- 書籍が存在するか確認
    IF EXISTS (SELECT 1 FROM statuses WHERE book_id = @BookId and status_num = 0)
		BEGIN
			-- 書籍が存在する場合はstatusesテーブルを更新、０を返す
			UPDATE statuses set status_num = 1 where book_id = @BookId;
			RETURN 0;
		END
    ELSE
		BEGIN
			-- 書籍が存在しない場合は中止、-1を返す
			RETURN -1;
		END
END;