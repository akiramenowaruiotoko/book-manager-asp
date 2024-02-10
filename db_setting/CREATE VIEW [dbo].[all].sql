USE [book_manager]
GO

/****** Object:  View [dbo].[viewAll]    Script Date: 2024/02/10 22:56:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[viewAll]
AS
	select
		b.book_id,
		b.book_name,
		e.employee_number,
		e.first_name,
		s.status_id,
		s.status_num,
		s.rent_date,
		s.return_date
	from
		books AS b
		left join statuses AS s
			ON b.book_id = s.book_id
		left join employees AS e
			ON  s.employee_number = e.employee_number;
GO

