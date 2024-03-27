USE [book_manager]
GO

CREATE OR ALTER PROCEDURE [dbo].[DeleteBook]
    @TargetBookId VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- ���Ђ����݂��邩�m�F
    IF EXISTS (SELECT 1 FROM books WHERE book_id = @TargetBookId)
		BEGIN
			-- ���݂���ꍇ�͍폜
			DELETE FROM books WHERE book_id = @TargetBookId;
			RETURN 0; -- �폜����
		END
    ELSE
		BEGIN
			-- ���݂��Ȃ��ꍇ�͍폜���~
			RETURN -1; -- �폜�Ώۂ����݂��Ȃ�
		END
END;
