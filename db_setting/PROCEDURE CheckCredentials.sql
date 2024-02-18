USE [book_manager]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[CheckCredentials]
    @EmpNum INT,
    @EmpPass VARCHAR(50),
    @IsEditor BIT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

      -- ‰Šú’l‚ğİ’è
    SET @IsEditor = 0;

    IF EXISTS (SELECT 1
               FROM View_employees 
               WHERE employee_number = @EmpNum AND employee_password = @EmpPass)
		BEGIN
			SELECT @IsEditor = editor
			FROM View_employees 
			WHERE employee_number = @EmpNum AND employee_password = @EmpPass;
        
			-- ¬Œ÷‚ğ¦‚·–ß‚è’l‚Æ‚µ‚Ä0‚ğ•Ô‚·
			RETURN 0;
		END
    ELSE
		BEGIN
			-- ¸”s‚ğ¦‚·–ß‚è’l‚Æ‚µ‚Ä-1‚ğ•Ô‚·
			RETURN -1;
		END
END;
