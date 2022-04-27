using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("Period")]
	public sealed class PeriodDal
	{
		public PeriodDal()
		{
			PromoCodeTypeServices = new HashSet<PromoCodeTypeServiceDal>();
			TariffPlanDurations = new HashSet<TariffPlanDurationDal>();
		}

		public long PeriodId { get; set; }
		public int Value { get; set; }
		public int PeriodUnitId { get; set; }

		public PeriodUnitDal PeriodUnit { get; set; }
		public ICollection<PromoCodeTypeServiceDal> PromoCodeTypeServices { get; set; }
		public ICollection<TariffPlanDurationDal> TariffPlanDurations { get; set; }
	}
}
