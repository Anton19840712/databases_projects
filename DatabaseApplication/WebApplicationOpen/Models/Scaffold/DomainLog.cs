

namespace WebApplicationOpen.Models.Scaffold
{
	public class DomainLog
	{
		public long DomainLogId { get; set; }
		public long LogId { get; set; }
		public long DomainHistoryId { get; set; }

		public virtual DomainHistory DomainHistory { get; set; }
		public virtual LogRepository Log { get; set; }
	}
}
