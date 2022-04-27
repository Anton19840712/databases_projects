

namespace WebApplicationOpen.Models.Scaffold
{
	public class PromoCodeTypeService
	{
		public long PromoCodeTypeServiceId { get; set; }
		public long PromoCodeId { get; set; }
		public int ServiceTypeId { get; set; }
		public long? TariffPlanId { get; set; }
		public int? DurationMonths { get; set; }
		public bool Delete { get; set; }
		public long? TarifficationAmountWorkId { get; set; }
		public long? PeriodId { get; set; }

		public virtual Period Period { get; set; }
		public virtual PromoCode PromoCode { get; set; }
		public virtual ServiceType ServiceType { get; set; }
		public virtual TariffPlan TariffPlan { get; set; }
		public virtual TarifficationAmountWork TarifficationAmountWork { get; set; }
	}
}
