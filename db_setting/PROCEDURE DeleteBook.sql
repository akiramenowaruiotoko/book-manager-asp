USE [book_manager]
GO

CREATE OR ALTER PROCEDURE [dbo].[DeleteBook]
    @TargetBookId VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- ‘Ð‚ª‘¶Ý‚·‚é‚©Šm”F
    IF EXISTS (SELECT 1 FROM books WHERE book_id = @TargetBookId)
		BEGIN
			-- ‘¶Ý‚·‚éê‡‚Ííœ
			DELETE FROM books WHERE book_id = @TargetBookId;
			RETURN 0; -- íœ¬Œ÷
		END
    ELSE
		BEGIN
			-- ‘¶Ý‚µ‚È‚¢ê‡‚Ííœ’†Ž~
			RETURN -1; -- íœ‘ÎÛ‚ª‘¶Ý‚µ‚È‚¢
		END
END;
