using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace RentCar.Areas.Identity.Data
{
	public class ApplicationUser : IdentityUser
	{
		[PersonalData]
		[Column(TypeName = "nvarchar(100)")]
		public string FirstName { get; set; }
		[PersonalData]
		[Column(TypeName = "nvarchar(100)")]
		public string LastName { get; set; }
		[PersonalData]
		[Column(TypeName = "varchar(100)")]
		public string EGN { get; set; }
		[PersonalData]
		[Column(TypeName = "nvarchar(MAX)")]
		public string Address { get; set; }
	}
}
