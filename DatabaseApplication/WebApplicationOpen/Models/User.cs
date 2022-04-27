using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models
{
	public class User
	{
		[Key]
		public long UserId { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public DateTime LastVisitDate { get; set; } = DateTime.Now;
		public bool IsActive { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime RegistrationDate { get; set; }

	}
}
