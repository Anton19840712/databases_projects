

namespace WebApplicationOpen.Models.Scaffold
{
	public class TariffPlanCost
	{
		public long TariffPlanCostId { get; set; }
		public long TariffPlanId { get; set; }
		public long CostId { get; set; }
		public int OrderActionId { get; set; }

		public virtual Cost Cost { get; set; }
		public virtual OrderAction OrderAction { get; set; }
		public virtual TariffPlan TariffPlan { get; set; }
	}
}
