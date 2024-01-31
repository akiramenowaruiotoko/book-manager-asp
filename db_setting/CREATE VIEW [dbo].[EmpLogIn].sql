USE [book_manager]
GO

/****** Object:  View [dbo].[viewAll]    Script Date: 2024/01/31 21:56:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[viewAll]
AS
	select
		b.book_name,
		s.status_num,
		e.first_name
	from
		books AS b
		left join statuses AS s
			ON b.book_id = s.book_id
		left join employees AS e
			ON  s.employee_number = e.employee_number;
GO

