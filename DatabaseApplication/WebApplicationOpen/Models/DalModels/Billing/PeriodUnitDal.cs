using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.TariffPlans;

namespace WebApplicationOpen.Models.DalModels.Billing
{
	[Table("PeriodUnit")]
	public sealed class PeriodUnitDal
	{
		public PeriodUnitDal()
		{
			Periods = new HashSet<PeriodDal>();
			TariffPlans = new HashSet<TariffPlanDal>();
			TarifficationAmountWorks = new HashSet<TarifficationAmountWorkDal>();
		}

		[Key]
		public int PeriodUnitId { get; set; }
		public string Unit { get; set; }

		public ICollection<PeriodDal> Periods { get; set; }
		public ICollection<TariffPlanDal> TariffPlans { get; set; }
		public ICollection<TarifficationAmountWorkDal> TarifficationAmountWorks { get; set; }
	}
}
