using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("DomainHistory")]
	public sealed class DomainHistoryDal
	{
		public DomainHistoryDal()
		{
			DomainLogs = new HashSet<DomainLogDal>();
			ServiceHistories = new HashSet<ServiceHistoryDal>();
		}

		[Key]
		public long DomainHistoryId { get; set; }
		public int DomainZoneId { get; set; }
		public string Name { get; set; }

		public DomainZoneDal DomainZone { get; set; }
		public ICollection<DomainLogDal> DomainLogs { get; set; }
		public ICollection<ServiceHistoryDal> ServiceHistories { get; set; }
	}
}
