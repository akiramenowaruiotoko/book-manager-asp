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

    -- ���Ђ����݂��A�ŐV�̃X�e�[�^�X��3���m�F
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
        -- ���Ђ����݂��A�X�e�[�^�X��3�̏ꍇ�͐V�����X�e�[�^�X��ǉ����ARETURN 0��Ԃ�
	    INSERT INTO statuses (book_id, employee_number, status_num, rental_date, return_date) 
        VALUES (@BookId, @EmployeeNumber, @StatusNum, @RentalDate, @ReturnDate);
        
        RETURN 0;
    END
    ELSE
    BEGIN
        -- ���Ђ����݂��Ȃ��A�܂��̓X�e�[�^�X��3�łȂ��ꍇ�͒��~�ARETURN -1��Ԃ�
        RETURN -1;
    END
END;
