using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.Billing;

namespace WebApplicationOpen.Models.DalModels.TariffPlans
{
	[Table("TariffPlanDurations")]
	public class TariffPlanDurationDal
	{
		[Key]
		public long TariffPlanDurationId { get; set; }
		public long TariffPlanId { get; set; }
		public int DurationMonths { get; set; }
		public int Discount { get; set; }
		public long? TarifficationAmountWorkId { get; set; }
		public long? PeriodId { get; set; }

		public virtual PeriodDal Period { get; set; }
		public virtual TariffPlanDal TariffPlan { get; set; }
		public virtual TarifficationAmountWorkDal TarifficationAmountWork { get; set; }
	}
}
