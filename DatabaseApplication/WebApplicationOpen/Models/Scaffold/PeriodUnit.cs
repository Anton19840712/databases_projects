using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class PeriodUnit
	{
		public PeriodUnit()
		{
			Periods = new HashSet<Period>();
			TariffPlans = new HashSet<TariffPlan>();
			TarifficationAmountWorks = new HashSet<TarifficationAmountWork>();
		}

		public int PeriodUnitId { get; set; }
		public string Unit { get; set; }

		public virtual ICollection<Period> Periods { get; set; }
		public virtual ICollection<TariffPlan> TariffPlans { get; set; }
		public virtual ICollection<TarifficationAmountWork> TarifficationAmountWorks { get; set; }
	}
}
