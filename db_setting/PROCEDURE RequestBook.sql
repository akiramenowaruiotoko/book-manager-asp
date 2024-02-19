USE [book_manager]
GO

CREATE OR ALTER PROCEDURE [dbo].[RequestBookPurchase]
    @BookId CHAR(10),
    @BookName VARCHAR(50),
    @EmployeeNumber INT,
    @StatusNum INT
AS
BEGIN
    SET NOCOUNT ON;

    -- 書籍が存在するか確認
    IF EXISTS (SELECT 1 FROM books WHERE book_id = @BookId)
		BEGIN
			-- 書籍が既に存在する場合は申請中止
			RETURN -1;
		END
    ELSE
		BEGIN
			-- 書籍が存在しない場合は申請成功（books, statusesテーブルを更新)
			INSERT INTO books (book_id, book_name) VALUES (@BookId, @BookName);
			INSERT INTO statuses (book_id, employee_number, status_num) VALUES (@BookId, @EmployeeNumber, @StatusNum); 
			RETURN 0;
		END
END;
