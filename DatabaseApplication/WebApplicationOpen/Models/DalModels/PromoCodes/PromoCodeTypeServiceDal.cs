using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.BaseTablesForServices;
using WebApplicationOpen.Models.DalModels.Billing;
using WebApplicationOpen.Models.DalModels.TariffPlans;

namespace WebApplicationOpen.Models.DalModels.PromoCodes
{
	[Table("PromoCodeTypeServices")]
	public class PromoCodeTypeServiceDal
	{
		[Key]
		public long PromoCodeTypeServiceId { get; set; }
		public long PromoCodeId { get; set; }
		public int ServiceTypeId { get; set; }
		public long? TariffPlanId { get; set; }
		public int? DurationMonths { get; set; }
		public bool Delete { get; set; }
		public long? TarifficationAmountWorkId { get; set; }
		public long? PeriodId { get; set; }

		public virtual PeriodDal Period { get; set; }
		public virtual PromoCodeDal PromoCode { get; set; }
		public virtual ServiceTypeDal ServiceType { get; set; }
		public virtual TariffPlanDal TariffPlan { get; set; }
		public virtual TarifficationAmountWorkDal TarifficationAmountWork { get; set; }
	}
}
