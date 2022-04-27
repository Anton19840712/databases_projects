using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class Period
	{
		public Period()
		{
			PromoCodeTypeServices = new HashSet<PromoCodeTypeService>();
			TariffPlanDurations = new HashSet<TariffPlanDuration>();
		}

		public long PeriodId { get; set; }
		public int Value { get; set; }
		public int PeriodUnitId { get; set; }

		public virtual PeriodUnit PeriodUnit { get; set; }
		public virtual ICollection<PromoCodeTypeService> PromoCodeTypeServices { get; set; }
		public virtual ICollection<TariffPlanDuration> TariffPlanDurations { get; set; }
	}
}
