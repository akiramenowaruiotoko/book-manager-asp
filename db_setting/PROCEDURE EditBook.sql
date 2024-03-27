USE [book_manager]
GO

CREATE OR ALTER PROCEDURE [dbo].[EditBook]
    @TargetBookId VARCHAR(50),
    @BookId VARCHAR(50),
    @BookName VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- book_id�����݂��邩�m�F
    IF EXISTS (SELECT 1 FROM books WHERE book_id = @TargetBookId)
		BEGIN
			-- ���݂���ꍇ�͐\������
			UPDATE books
			SET book_id = @BookId,
				book_name = @BookName
				where book_id = @TargetBookId
			RETURN 0;
		END
    ELSE
		BEGIN
			-- ���݂��Ȃ��ꍇ�͐\�����~
			RETURN -1;
		END
END;
