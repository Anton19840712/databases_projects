using System;
using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class UserSession
	{
		public UserSession()
		{
			LogRepositories = new HashSet<LogRepository>();
		}

		public long UserSessionId { get; set; }
		public DateTime StartDate { get; set; }
		public byte[] Ip { get; set; }

		public ICollection<LogRepository> LogRepositories { get; set; }
	}
}
