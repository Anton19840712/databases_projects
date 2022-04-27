using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("LogRepository")]
	public sealed class LogRepositoryDal
	{
		public LogRepositoryDal()
		{
			DomainLogs = new HashSet<DomainLogDal>();
			LogEvents = new HashSet<LogEventDal>();
			LogNotes = new HashSet<LogNoteDal>();
			UserLogs = new HashSet<UserLogDal>();
		}

		public long LogId { get; set; }
		public long UserId { get; set; }
		public int LogTypeId { get; set; }
		public DateTime LogDate { get; set; }
		public long? UserSessionId { get; set; }

		public LogTypeDal LogType { get; set; }
		public UserDal User { get; set; }
		public UserSessionDal UserSession { get; set; }
		public ICollection<DomainLogDal> DomainLogs { get; set; }
		public ICollection<LogEventDal> LogEvents { get; set; }
		public ICollection<LogNoteDal> LogNotes { get; set; }
		public ICollection<UserLogDal> UserLogs { get; set; }
	}
}
