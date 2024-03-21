USE [book_manager]
GO

CREATE OR ALTER PROCEDURE [dbo].[EditEmployee]
    @TargetEmployeeNumber INT,
    @EmployeeNumber INT,
    @EmployeePassword VARCHAR(50),
    @FirstName VARCHAR(50),
    @Editor BIT
AS
BEGIN
    SET NOCOUNT ON;

    -- �]�ƈ��ԍ������݂��邩�m�F
    IF EXISTS (SELECT 1 FROM employees WHERE employee_number = @TargetEmployeeNumber)
		BEGIN
			-- ���݂���ꍇ�͐\������
			UPDATE employees
			SET employee_number = @EmployeeNumber,
				employee_password = @EmployeePassword,
				first_name = @FirstName,
				editor = @Editor
				where employee_number = @TargetEmployeeNumber
			RETURN 0;
		END
    ELSE
		BEGIN
			-- ���݂��Ȃ��ꍇ�͐\�����~
			RETURN -1;
		END
END;
