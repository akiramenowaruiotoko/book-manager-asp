USE [book_manager]
GO

CREATE OR ALTER PROCEDURE [dbo].[AddEmployee]
    @EmployeeNumber INT,
    @EmployeePassword VARCHAR(50),
    @FirstName VARCHAR(50),
    @Editor BIT
AS
BEGIN
    SET NOCOUNT ON;

    -- �]�ƈ��ԍ������݂��邩�m�F
    IF EXISTS (SELECT 1 FROM employees WHERE employee_number = @EmployeeNumber)
		BEGIN
			-- ���ɑ��݂���ꍇ�͐\�����~
			RETURN -1;
		END
    ELSE
		BEGIN
			-- ���݂��Ȃ��ꍇ�͐\������
			INSERT INTO employees(employee_number, employee_password, first_name, editor) 
			VALUES (@EmployeeNumber, @EmployeePassword, @FirstName, @Editor); 
			RETURN 0;
		END
END;
