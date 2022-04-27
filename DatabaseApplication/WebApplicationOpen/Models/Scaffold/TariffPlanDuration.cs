

namespace WebApplicationOpen.Models.Scaffold
{
	public class TariffPlanDuration
	{
		public long TariffPlanDurationId { get; set; }
		public long TariffPlanId { get; set; }
		public int DurationMonths { get; set; }
		public int Discount { get; set; }
		public long? TarifficationAmountWorkId { get; set; }
		public long? PeriodId { get; set; }

		public virtual Period Period { get; set; }
		public virtual TariffPlan TariffPlan { get; set; }
		public virtual TarifficationAmountWork TarifficationAmountWork { get; set; }
	}
}
