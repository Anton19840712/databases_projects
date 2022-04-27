using System;
using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class LogRepository
	{
		public LogRepository()
		{
			DomainLogs = new HashSet<DomainLog>();
			LogEvents = new HashSet<LogEvent>();
			LogNotes = new HashSet<LogNote>();
			UserLogs = new HashSet<UserLog>();
		}

		public long LogId { get; set; }
		public long UserId { get; set; }
		public int LogTypeId { get; set; }
		public DateTime LogDate { get; set; }
		public long? UserSessionId { get; set; }

		public virtual LogType LogType { get; set; }
		public virtual User User { get; set; }
		public virtual UserSession UserSession { get; set; }
		public virtual ICollection<DomainLog> DomainLogs { get; set; }
		public virtual ICollection<LogEvent> LogEvents { get; set; }
		public virtual ICollection<LogNote> LogNotes { get; set; }
		public virtual ICollection<UserLog> UserLogs { get; set; }
	}
}
