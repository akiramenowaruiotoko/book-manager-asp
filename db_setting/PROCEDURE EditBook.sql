USE [book_manager]
GO

CREATE OR ALTER PROCEDURE [dbo].[EditBook]
    @TargetBookId VARCHAR(50),
    @BookId VARCHAR(50),
    @BookName VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- book_idが存在するか確認
    IF EXISTS (SELECT 1 FROM books WHERE book_id = @TargetBookId)
		BEGIN
			-- 存在する場合は申請成功
			UPDATE books
			SET book_id = @BookId,
				book_name = @BookName
				where book_id = @TargetBookId
			RETURN 0;
		END
    ELSE
		BEGIN
			-- 存在しない場合は申請中止
			RETURN -1;
		END
END;
