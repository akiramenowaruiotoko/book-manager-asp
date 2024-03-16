USE [book_manager]
GO

CREATE OR ALTER PROCEDURE [dbo].[PurchaseResponse]
    @BookId CHAR(10), -- 書籍ID
    @EmployeeNumber INT, -- 従業員番号
    @StatusNum INT -- ステータス番号
AS
BEGIN
    SET NOCOUNT ON;

    -- 書籍が存在し、かつステータスが0、1、2のいずれかのみ存在する場合
    IF EXISTS (SELECT 1 FROM statuses WHERE book_id = @BookId AND status_num IN (0, 1, 2))
    BEGIN
        -- 新しいレコードを挿入し、成功を示す値を返す
        INSERT INTO statuses (book_id, employee_number, status_num) VALUES (@BookId, @EmployeeNumber, @StatusNum);
        RETURN 0; -- 成功を示す値
    END
    ELSE
    BEGIN
        -- 書籍が存在しないか、ステータスが0、1、2以外の値を持つ場合、失敗を示す値を返す
        RETURN -1; -- 失敗を示す値
    END
END;
