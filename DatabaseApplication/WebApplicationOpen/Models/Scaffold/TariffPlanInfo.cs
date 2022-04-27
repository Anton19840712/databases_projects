

namespace WebApplicationOpen.Models.Scaffold
{
	public class TariffPlanInfo
	{
		public long TariffPlanInfoId { get; set; }
		public long TariffPlanId { get; set; }
		public int LanguageId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string SpaceSize { get; set; }
		public string ToolTipDiscription { get; set; }

		public virtual Language Language { get; set; }
		public virtual TariffPlan TariffPlan { get; set; }
	}
}
