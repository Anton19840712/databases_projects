using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
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

		public int PeriodUnitId { get; set; }
		public string Unit { get; set; }

		public ICollection<PeriodDal> Periods { get; set; }
		public ICollection<TariffPlanDal> TariffPlans { get; set; }
		public ICollection<TarifficationAmountWorkDal> TarifficationAmountWorks { get; set; }
	}
}
