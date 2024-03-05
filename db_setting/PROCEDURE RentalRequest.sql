USE [book_manager]
GO

CREATE OR ALTER PROCEDURE [dbo].[RentalRequest]
    @BookId CHAR(10),
    @EmployeeNumber INT,
    @RentDate DATE,
    @ReturnDate DATE
AS
BEGIN
    SET NOCOUNT ON;

    -- 書籍が存在し、ステータスが１か確認
    IF EXISTS (SELECT 1 FROM statuses WHERE book_id = @BookId and status_num = 1)
		BEGIN
			-- 書籍が存在し、ステータスが１の場合はstatusesテーブルを更新、RETURN 0を返す
			UPDATE statuses 
				set
					employee_number = @EmployeeNumber,
					status_num = 2,
					rent_date = @RentDate,
					return_date = @ReturnDate
				where book_id = @BookId;
			RETURN 0;
		END
    ELSE
		BEGIN
			-- 書籍が存在しない、またはステータスが１以外の場合は中止、RETURN -1を返す
			RETURN -1;
		END
END;