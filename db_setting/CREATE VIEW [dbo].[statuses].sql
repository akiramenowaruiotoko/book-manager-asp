USE [book_manager]
GO

CREATE OR ALTER VIEW [dbo].[view_statuses]
AS
SELECT
    status_id, -- �X�e�[�^�XID
    book_id, -- ����ID
    employee_number, -- �]�ƈ��ԍ�
    status_num, -- �X�e�[�^�X�ԍ�
    rental_date, -- �ݏo��
    return_date, -- �ԋp��
    update_datetime -- �X�e�[�^�X�̍X�V����
FROM
    statuses;
GO
