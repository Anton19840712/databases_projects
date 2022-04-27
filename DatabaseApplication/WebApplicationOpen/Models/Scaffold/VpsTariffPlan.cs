

namespace WebApplicationOpen.Models.Scaffold
{
	public class VpsTariffPlan
	{
		public long VpsTariffPlanId { get; set; }
		public long TariffPlanId { get; set; }
		public long? VpsTariffPlanConfigId { get; set; }
		public bool IsConstructor { get; set; }

		public virtual TariffPlan TariffPlan { get; set; }
		public virtual VpsConfig VpsTariffPlanConfig { get; set; }
	}
}
