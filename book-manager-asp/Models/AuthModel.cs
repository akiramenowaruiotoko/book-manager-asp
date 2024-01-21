using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace book_manager_asp.Models
{
	public class AuthModel
	{
		[Display(Name = "employee number")]
		[Required(ErrorMessage = "employee number is required")]
		public string EmpNum { get; set; }

		[Display(Name = "password")]
		[Required(ErrorMessage = "password is required")]
		public string EmpPass { get; set; }
	}
}