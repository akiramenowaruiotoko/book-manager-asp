USE [book_manager]
GO

CREATE OR ALTER PROCEDURE [dbo].[PurchaseComplete]
    @BookId CHAR(10),
    @EmployeeNumber INT,
    @StatusNum INT
AS
BEGIN
    SET NOCOUNT ON;

    -- 書籍が存在し、ステータスが０のみか確認
    IF NOT EXISTS (SELECT 1 FROM statuses WHERE book_id = @BookId AND status_num <> 0)
    BEGIN
        -- 書籍が存在し、ステータスが０のみの場合はstatusesテーブルに新しいレコードを挿入し、RETURN 0を返す
        INSERT INTO statuses (book_id, employee_number, status_num) VALUES (@BookId, @EmployeeNumber, @StatusNum);
        RETURN 0;
    END
    ELSE
    BEGIN
        -- ステータスが０以外のレコードが存在する場合は中止し、RETURN -1を返す
        RETURN -1;
    END
END;
