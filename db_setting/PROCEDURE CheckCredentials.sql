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

      -- 初期値を設定
    SET @IsEditor = 0;

    IF EXISTS (SELECT 1
               FROM View_employees 
               WHERE employee_number = @EmpNum AND employee_password = @EmpPass)
		BEGIN
			SELECT @IsEditor = editor
			FROM View_employees 
			WHERE employee_number = @EmpNum AND employee_password = @EmpPass;
        
			-- 成功を示す戻り値として1を返す
			RETURN 1;
		END
    ELSE
		BEGIN
			-- 失敗を示す戻り値として0を返す
			RETURN 0;
		END
END;
