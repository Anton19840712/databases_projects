using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class User
	{
		public User()
		{
			Clients = new HashSet<ClientDal>();
			LogRepositories = new HashSet<LogRepository>();
			PasswordRecoveries = new HashSet<PasswordRecovery>();
			UserInRoles = new HashSet<UserInRole>();
			UserLogs = new HashSet<UserLog>();
		}
		[Key]
		public long UserId { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public DateTime LastVisitDate { get; set; }
		public bool IsActive { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime RegistrationDate { get; set; }

		public BackEndUserDal BackEndUser { get; set; }
		public ICollection<ClientDal> Clients { get; set; }
		public ICollection<LogRepository> LogRepositories { get; set; }
		public ICollection<PasswordRecovery> PasswordRecoveries { get; set; }
		public ICollection<UserInRole> UserInRoles { get; set; }
		public ICollection<UserLog> UserLogs { get; set; }
	}
}
