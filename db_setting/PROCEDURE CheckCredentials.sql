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
    
    IF EXISTS (SELECT 1
               FROM View_employees 
               WHERE employee_number = @EmpNum AND employee_password = @EmpPass)
		BEGIN
			-- �Ή����郌�R�[�h������ꍇ�A@IsEditor��editor�̒l�����蓖�Ă�
			SELECT @IsEditor = editor
			FROM View_employees 
			WHERE employee_number = @EmpNum AND employee_password = @EmpPass;
        
			-- �����������߂�l�Ƃ���1��Ԃ�
			RETURN 1;
		END
    ELSE
		BEGIN
			-- ���s�������߂�l�Ƃ���0��Ԃ�
			RETURN 0;
		END
END;
