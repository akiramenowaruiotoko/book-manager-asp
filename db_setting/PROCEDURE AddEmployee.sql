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

    -- 従業員番号が存在するか確認
    IF EXISTS (SELECT 1 FROM employees WHERE employee_number = @EmployeeNumber)
		BEGIN
			-- 既に存在する場合は申請中止
			RETURN -1;
		END
    ELSE
		BEGIN
			-- 存在しない場合は申請成功
			INSERT INTO employees(employee_number, employee_password, first_name, editor) 
			VALUES (@EmployeeNumber, @EmployeePassword, @FirstName, @Editor); 
			RETURN 0;
		END
END;
