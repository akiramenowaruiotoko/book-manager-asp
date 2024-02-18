USE [book_manager]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[RequestBookPurchase]
    @BookId CHAR(10),
    @BookName VARCHAR(50),
    @EmployeeNumber INT,
    @StatusNum INT
AS
BEGIN
    SET NOCOUNT ON;

    -- ���Ђ����݂��邩�m�F
    IF EXISTS (SELECT 1 FROM books WHERE book_id = @BookId)
    BEGIN
        -- ���Ђ����݂���ꍇ�͐\�����~
		RETURN -1;
    END
    ELSE
    BEGIN
        -- ���Ђ����݂��Ȃ��ꍇ�͐\�����������s
        INSERT INTO books (book_id, book_name) VALUES (@BookId, @BookName);
        INSERT INTO statuses (book_id, employee_number, status_num) VALUES (@BookId, @EmployeeNumber, @StatusNum); 
		RETURN 0;
    END
END;
