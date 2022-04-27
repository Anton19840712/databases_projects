using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("LogEventType")]
	public sealed class LogEventTypeDal
	{
		public LogEventTypeDal()
		{
			LogEvents = new HashSet<LogEventDal>();
		}

		public long LogEventTypeId { get; set; }
		public string Description { get; set; }

		public ICollection<LogEventDal> LogEvents { get; set; }
	}
}
