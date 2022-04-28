using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.Common;
using WebApplicationOpen.Models.DalModels.TariffPlans;

namespace WebApplicationOpen.Models.DalModels.Domains
{
	[Table("DomainZones")]
	public sealed class DomainZoneDal
	{
		public DomainZoneDal()
		{
			DomainHistories = new HashSet<DomainHistoryDal>();
			Domains = new HashSet<DomainDal>();
			Statistics = new HashSet<StatisticDal>();
			TariffPlans = new HashSet<TariffPlanDal>();
		}
		[Key]
		public int DomainZoneId { get; set; }
		public string Name { get; set; }
		public string Label { get; set; }
		public bool IsActive { get; set; }

		public ICollection<DomainHistoryDal> DomainHistories { get; set; }
		public ICollection<DomainDal> Domains { get; set; }
		public ICollection<StatisticDal> Statistics { get; set; }
		public ICollection<TariffPlanDal> TariffPlans { get; set; }
	}
}
