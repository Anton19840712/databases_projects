using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("UserSession")]
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
