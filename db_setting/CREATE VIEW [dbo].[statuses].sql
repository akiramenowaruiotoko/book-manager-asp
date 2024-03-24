USE [book_manager]
GO

CREATE OR ALTER VIEW [dbo].[view_statuses]
AS
SELECT
    status_id, -- ステータスID
    book_id, -- 書籍ID
    employee_number, -- 従業員番号
    status_num, -- ステータス番号
    rental_date, -- 貸出日
    return_date, -- 返却日
    update_datetime -- ステータスの更新日時
FROM
    statuses;
GO
