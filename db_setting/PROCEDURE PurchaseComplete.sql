USE [book_manager]
GO

CREATE OR ALTER PROCEDURE [dbo].[PurchaseComplete]
    @BookId CHAR(10),
	@EmployeeNumber INT,
    @StatusNum INT
AS
BEGIN
    SET NOCOUNT ON;

    -- 書籍が存在し、ステータスが０か確認
    IF EXISTS (SELECT 1 FROM statuses WHERE book_id = @BookId and status_num = 0)
		BEGIN
			-- 書籍が存在しステータスが０の場合はstatusesテーブルを更新、RETURN 0を返す
			INSERT INTO statuses (book_id, employee_number, status_num) VALUES (@BookId, @EmployeeNumber, @StatusNum);
			RETURN 0;
		END
    ELSE
		BEGIN
			-- 書籍が存在しない場合は中止、RETURN -1を返す
			RETURN -1;
		END
END;