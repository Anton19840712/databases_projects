﻿

namespace WebApplicationOpen.Models.Scaffold
{
	public class LogEvent
	{
		public long LogEventId { get; set; }
		public long LogId { get; set; }
		public long LogEventTypeId { get; set; }
		public string Value { get; set; }

		public virtual LogRepository Log { get; set; }
		public virtual LogEventType LogEventType { get; set; }
	}
}
