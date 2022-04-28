using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.Billing;
using WebApplicationOpen.Models.DalModels.Logs;

namespace WebApplicationOpen.Models.DalModels.Domains
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
