using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ekbana.Models
{
    public class Employee
    {
		[Key]
		public int EmployeeID { get; set; }

		[Column(TypeName = "nvarchar(250)")]
		[Required(ErrorMessage = "This field is required.")]
		[DisplayName("Full Name")]
		public string FullName { get; set; }


		[DataType(DataType.EmailAddress)]
		//[EmailAddress]
		[Column(TypeName = "varchar(100)")]
		[DisplayName("Email")]
		public string Email { get; set; }


		[Column(TypeName = "varchar(100)")]
		[DisplayName("Password")]
		public string Password { get; set; }

		
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "varchar(100")]
		[DataType(DataType.Date)]
		[DisplayName("DateOfBirth")]
		public string DateOfBirth { get; set; }


		[ForeignKey("RoleID")]
		public Role Role { get; set; }

		[ForeignKey("EmployeeParentID")]
		public EmployeeParent EmployeeParent { get; set; }
	}
}
