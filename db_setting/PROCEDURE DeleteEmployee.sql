USE [book_manager]
GO

CREATE OR ALTER PROCEDURE [dbo].[DeleteEmployee]
    @TargetEmployeeNumber INT
AS
BEGIN
    SET NOCOUNT ON;

    -- ‘Ğ‚ª‘¶İ‚·‚é‚©Šm”F
    IF EXISTS (SELECT 1 FROM employees WHERE employee_number = @TargetEmployeeNumber)
		BEGIN
			-- ‘¶İ‚·‚éê‡‚Ííœ
			DELETE FROM employees WHERE employee_number = @TargetEmployeeNumber;
			RETURN 0; -- íœ¬Œ÷
		END
    ELSE
		BEGIN
			-- ‘¶İ‚µ‚È‚¢ê‡‚Ííœ’†~
			RETURN -1; -- íœ‘ÎÛ‚ª‘¶İ‚µ‚È‚¢
		END
END;
