USE [book_manager]
GO

CREATE OR ALTER VIEW [dbo].[view_all]
AS
SELECT
    b.book_id, -- ����ID
    b.book_name, -- ���Ж�
    e.employee_number, -- �]�ƈ��ԍ�
    e.first_name, -- �]�ƈ��̖��O
    s.status_id, -- �X�e�[�^�XID
    s.status_num, -- �X�e�[�^�X�ԍ�
    s.rental_date, -- �ݏo��
    s.return_date, -- �ԋp��
    s.update_datetime -- �X�e�[�^�X�̍X�V����
FROM
    books AS b
LEFT JOIN
    statuses AS s ON b.book_id = s.book_id
LEFT JOIN
    employees AS e ON s.employee_number = e.employee_number
WHERE
    s.update_datetime = (
        -- �e���Ђ̍ŐV�̍X�V�����������R�[�h�݂̂��擾
        SELECT MAX(update_datetime)
        FROM statuses
        WHERE book_id = b.book_id
    );
GO
