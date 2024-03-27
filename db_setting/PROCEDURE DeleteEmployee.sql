USE [book_manager]
GO

CREATE OR ALTER PROCEDURE [dbo].[DeleteEmployee]
    @TargetEmployeeNumber INT
AS
BEGIN
    SET NOCOUNT ON;

    -- ���Ђ����݂��邩�m�F
    IF EXISTS (SELECT 1 FROM employees WHERE employee_number = @TargetEmployeeNumber)
		BEGIN
			-- ���݂���ꍇ�͍폜
			DELETE FROM employees WHERE employee_number = @TargetEmployeeNumber;
			RETURN 0; -- �폜����
		END
    ELSE
		BEGIN
			-- ���݂��Ȃ��ꍇ�͍폜���~
			RETURN -1; -- �폜�Ώۂ����݂��Ȃ�
		END
END;
