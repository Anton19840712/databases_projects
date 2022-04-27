using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("DomainLog")]
	public class DomainLogDal
	{
		public long DomainLogId { get; set; }
		public long LogId { get; set; }
		public long DomainHistoryId { get; set; }

		public virtual DomainHistoryDal DomainHistory { get; set; }
		public virtual LogRepository Log { get; set; }
	}
}
