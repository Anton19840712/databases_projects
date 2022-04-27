using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("TariffPlanCost")]
	public class TariffPlanCostDal
	{
		public long TariffPlanCostId { get; set; }
		public long TariffPlanId { get; set; }
		public long CostId { get; set; }
		public int OrderActionId { get; set; }

		public virtual CostDal Cost { get; set; }
		public virtual OrderActionDal OrderAction { get; set; }
		public virtual TariffPlanDal TariffPlan { get; set; }
	}
}
