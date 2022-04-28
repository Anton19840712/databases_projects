using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("DomainLog")]
	public class DomainLogDal
	{
		[Key]
		public long DomainLogId { get; set; }
		public long LogId { get; set; }
		public long DomainHistoryId { get; set; }

		public virtual DomainHistoryDal DomainHistory { get; set; }
		public virtual LogRepositoryDal Log { get; set; }
	}
}
