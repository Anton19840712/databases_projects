using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("TariffPlanDuration")]
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
