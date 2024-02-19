USE [book_manager]
GO

CREATE OR ALTER PROCEDURE [dbo].[CheckCredentials]
    @EmpNum INT,
    @EmpPass VARCHAR(50),
    @IsEditor BIT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    -- 対象レコードが存在するか確認。
    IF EXISTS (SELECT 1
               FROM View_employees 
               WHERE employee_number = @EmpNum AND employee_password = @EmpPass)
		BEGIN
		    -- 対象レコードが存在する場合、レコードのeditor値と承認成功(0)を返す。
			SELECT @IsEditor = editor
			FROM View_employees 
			WHERE employee_number = @EmpNum AND employee_password = @EmpPass;
			RETURN 0;
		END
    ELSE
		BEGIN
			-- 対象レコードが存在しない場合、編集権限なし(0)と承認失敗(-1)を返す。
		    SET @IsEditor = 0;
			RETURN -1;
		END
END;
