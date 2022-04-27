using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class LogEventType
	{
		public LogEventType()
		{
			LogEvents = new HashSet<LogEvent>();
		}

		public long LogEventTypeId { get; set; }
		public string Description { get; set; }

		public virtual ICollection<LogEvent> LogEvents { get; set; }
	}
}
