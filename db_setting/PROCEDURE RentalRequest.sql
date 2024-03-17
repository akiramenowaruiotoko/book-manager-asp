USE [book_manager]
GO

CREATE OR ALTER PROCEDURE [dbo].[RentalRequest]
    @BookId CHAR(10),
    @EmployeeNumber INT,
	@StatusNum INT,
    @RentalDate DATE,
    @ReturnDate DATE
AS
BEGIN
    SET NOCOUNT ON;

    -- 書籍が存在し、最新のステータスが3か確認
    IF EXISTS (
        SELECT 1 
        FROM statuses 
        WHERE book_id = @BookId 
        AND status_num = 3
        AND update_datetime = (
            SELECT MAX(update_datetime) 
            FROM statuses 
            WHERE book_id = @BookId
        )
    )
    BEGIN
        -- 書籍が存在し、ステータスが3の場合は新しいステータスを追加し、RETURN 0を返す
	    INSERT INTO statuses (book_id, employee_number, status_num, rental_date, return_date) 
        VALUES (@BookId, @EmployeeNumber, @StatusNum, @RentalDate, @ReturnDate);
        
        RETURN 0;
    END
    ELSE
    BEGIN
        -- 書籍が存在しない、またはステータスが3でない場合は中止、RETURN -1を返す
        RETURN -1;
    END
END;
