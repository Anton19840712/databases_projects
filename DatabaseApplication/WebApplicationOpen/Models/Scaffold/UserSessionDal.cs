using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("UserSession")]
	public sealed class UserSessionDal
	{
		public UserSessionDal()
		{
			LogRepositories = new HashSet<LogRepository>();
		}

		public long UserSessionId { get; set; }
		public DateTime StartDate { get; set; }
		public byte[] Ip { get; set; }

		public ICollection<LogRepository> LogRepositories { get; set; }
	}
}
