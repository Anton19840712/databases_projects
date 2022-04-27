using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("LogEvent")]
	public class LogEventDal
	{
		public long LogEventId { get; set; }
		public long LogId { get; set; }
		public long LogEventTypeId { get; set; }
		public string Value { get; set; }

		public virtual LogRepositoryDal Log { get; set; }
		public virtual LogEventTypeDal LogEventType { get; set; }
	}
}
