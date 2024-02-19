USE [book_manager]
GO

CREATE OR ALTER PROCEDURE [dbo].[CheckCredentials]
    @EmpNum INT,
    @EmpPass VARCHAR(50),
    @IsEditor BIT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    -- �Ώۃ��R�[�h�����݂��邩�m�F�B
    IF EXISTS (SELECT 1
               FROM View_employees 
               WHERE employee_number = @EmpNum AND employee_password = @EmpPass)
		BEGIN
		    -- �Ώۃ��R�[�h�����݂���ꍇ�A���R�[�h��editor�l�Ə��F����(0)��Ԃ��B
			SELECT @IsEditor = editor
			FROM View_employees 
			WHERE employee_number = @EmpNum AND employee_password = @EmpPass;
			RETURN 0;
		END
    ELSE
		BEGIN
			-- �Ώۃ��R�[�h�����݂��Ȃ��ꍇ�A�ҏW�����Ȃ�(0)�Ə��F���s(-1)��Ԃ��B
		    SET @IsEditor = 0;
			RETURN -1;
		END
END;
