CREATE PROCEDURE CheckCredentials
    @EmpNum NVARCHAR(50),
    @EmpPass NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT COUNT(*) 
    FROM View_employees 
    WHERE employee_number = @EmpNum AND employee_password = @EmpPass;
END;
