USE [book_manager]
GO

CREATE OR ALTER VIEW [dbo].[view_all]
AS
SELECT
    b.book_id, -- 書籍ID
    b.book_name, -- 書籍名
    e.employee_number, -- 従業員番号
    e.first_name, -- 従業員の名前
    s.status_id, -- ステータスID
    s.status_num, -- ステータス番号
    s.rental_date, -- 貸出日
    s.return_date, -- 返却日
    s.update_datetime -- ステータスの更新日時
FROM
    books AS b
LEFT JOIN
    statuses AS s ON b.book_id = s.book_id
LEFT JOIN
    employees AS e ON s.employee_number = e.employee_number
WHERE
    s.update_datetime = (
        -- 各書籍の最新の更新日時を持つレコードのみを取得
        SELECT MAX(update_datetime)
        FROM statuses
        WHERE book_id = b.book_id
    );
GO
