using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class LogType
	{
		public LogType()
		{
			LogRepositories = new HashSet<LogRepository>();
		}

		public int LogTypeId { get; set; }
		public string Description { get; set; }

		public virtual ICollection<LogRepository> LogRepositories { get; set; }
	}
}
