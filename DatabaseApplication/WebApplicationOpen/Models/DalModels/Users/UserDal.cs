using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.Clients;
using WebApplicationOpen.Models.DalModels.Logs;

namespace WebApplicationOpen.Models.DalModels.Users
{
	[Table("Users")]
	public sealed class UserDal
	{
		public UserDal()
		{
			Clients = new HashSet<ClientDal>();
			LogRepositories = new HashSet<LogRepositoryDal>();
			PasswordRecoveries = new HashSet<PasswordRecoveryDal>();
			UserInRoles = new HashSet<UserInRoleDal>();
			UserLogs = new HashSet<UserLogDal>();
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
		public ICollection<LogRepositoryDal> LogRepositories { get; set; }
		public ICollection<PasswordRecoveryDal> PasswordRecoveries { get; set; }
		public ICollection<UserInRoleDal> UserInRoles { get; set; }
		public ICollection<UserLogDal> UserLogs { get; set; }
	}
}
