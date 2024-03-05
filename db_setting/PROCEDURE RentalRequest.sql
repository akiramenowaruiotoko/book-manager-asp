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

    -- ���Ђ����݂��A�X�e�[�^�X���P���m�F
    IF EXISTS (SELECT 1 FROM statuses WHERE book_id = @BookId and status_num = 1)
		BEGIN
			-- ���Ђ����݂��A�X�e�[�^�X���P�̏ꍇ��statuses�e�[�u�����X�V�ARETURN 0��Ԃ�
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
			-- ���Ђ����݂��Ȃ��A�܂��̓X�e�[�^�X���P�ȊO�̏ꍇ�͒��~�ARETURN -1��Ԃ�
			RETURN -1;
		END
END;