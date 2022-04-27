using System;

namespace ConsoleAppOpenContactDatabaseFirstApproach.Models
{
	public class UserViewModel
	{
		public long UserId { get; set; }
		public string FullName { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public DateTime LastVisitDate { get; set; } = DateTime.Now;
		public bool IsActivated { get; set; }
		public DateTime RegistrationDate { get; set; }
		public UserRoleEnum Role { get; set; }
	}
}