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

    -- 従業員番号が存在するか確認
    IF EXISTS (SELECT 1 FROM employees WHERE employee_number = @TargetEmployeeNumber)
		BEGIN
			-- 存在する場合は申請成功
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
			-- 存在しない場合は申請中止
			RETURN -1;
		END
END;
