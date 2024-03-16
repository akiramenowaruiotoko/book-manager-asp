USE [book_manager]
GO

CREATE OR ALTER PROCEDURE [dbo].[PurchaseComplete]
    @BookId CHAR(10),
    @EmployeeNumber INT,
    @StatusNum INT
AS
BEGIN
    SET NOCOUNT ON;

	-- 書籍が存在し、ステータスが０または１のみか確認
	IF NOT EXISTS (SELECT 1 FROM statuses WHERE book_id = @BookId AND status_num NOT IN (0, 1))
    BEGIN
        -- TRUEの場合はstatusesテーブルに新しいレコードを挿入し、RETURN 0を返す
        INSERT INTO statuses (book_id, employee_number, status_num) VALUES (@BookId, @EmployeeNumber, @StatusNum);
        RETURN 0;
    END
    ELSE
    BEGIN
        -- FALSEの場合は中止し、RETURN -1を返す
        RETURN -1;
    END
END;
