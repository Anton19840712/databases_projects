using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.Logs;

namespace WebApplicationOpen.Models.DalModels.Users
{
	[Table("UserSessions")]
	public sealed class UserSessionDal
	{
		public UserSessionDal()
		{
			LogRepositories = new HashSet<LogRepositoryDal>();
		}

		[Key]
		public long UserSessionId { get; set; }
		public DateTime StartDate { get; set; }
		public byte[] Ip { get; set; }

		public ICollection<LogRepositoryDal> LogRepositories { get; set; }
	}
}
