USE [book_manager]
GO

CREATE OR ALTER PROCEDURE [dbo].[RentalManagement]
    @BookId CHAR(10), -- 書籍ID
    @EmployeeNumber INT, -- 従業員番号
    @StatusNum INT, -- ステータス番号
	@RentalDate DATE,
	@ReturnDate DATE
AS
BEGIN
    SET NOCOUNT ON;

    -- 書籍が存在し、かつ最新のステータスが4,5,6,7,8のいずれか場合
    IF EXISTS (
        SELECT 1 
        FROM statuses 
        WHERE book_id = @BookId 
        AND status_num IN (4, 5, 6, 7, 8)
        AND update_datetime = (
            SELECT MAX(update_datetime) 
            FROM statuses 
            WHERE book_id = @BookId
        )
    )
    BEGIN
        -- 新しいレコードを挿入し、成功を示す値を返す
        INSERT INTO statuses (book_id, employee_number, status_num, rental_date, return_date)
		VALUES (@BookId, @EmployeeNumber, @StatusNum, @RentalDate, @ReturnDate);
        RETURN 0; -- 成功を示す値
    END
    ELSE
    BEGIN
        RETURN -1; -- 失敗を示す値
    END
END;
