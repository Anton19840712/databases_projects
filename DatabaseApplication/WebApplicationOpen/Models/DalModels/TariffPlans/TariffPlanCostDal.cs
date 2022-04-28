using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.Billing;

namespace WebApplicationOpen.Models.DalModels.TariffPlans
{
	[Table("TariffPlanCosts")]
	public class TariffPlanCostDal
	{
		[Key]
		public long TariffPlanCostId { get; set; }
		public long TariffPlanId { get; set; }
		public long CostId { get; set; }
		public int OrderActionId { get; set; }

		public virtual CostDal Cost { get; set; }
		public virtual OrderActionDal OrderAction { get; set; }
		public virtual TariffPlanDal TariffPlan { get; set; }
	}
}
