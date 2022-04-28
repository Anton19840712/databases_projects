using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.Vps;

namespace WebApplicationOpen.Models.DalModels.TariffPlans
{
	[Table("VpsTariffPlans")]
	public class VpsTariffPlanDal
	{
		[Key]
		public long VpsTariffPlanId { get; set; }
		public long TariffPlanId { get; set; }
		public long? VpsTariffPlanConfigId { get; set; }
		public bool IsConstructor { get; set; }

		public virtual TariffPlanDal TariffPlan { get; set; }
		public virtual VpsConfigDal VpsTariffPlanConfig { get; set; }
	}
}
