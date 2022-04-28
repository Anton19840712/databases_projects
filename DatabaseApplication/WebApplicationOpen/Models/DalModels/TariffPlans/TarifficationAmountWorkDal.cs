using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.BaseTablesForServices;
using WebApplicationOpen.Models.DalModels.Billing;
using WebApplicationOpen.Models.DalModels.Common;
using WebApplicationOpen.Models.DalModels.PromoCodes;

namespace WebApplicationOpen.Models.DalModels.TariffPlans
{
	[Table("TarifficationAmountWork")]
	public sealed class TarifficationAmountWorkDal
	{
		public TarifficationAmountWorkDal()
		{
			Acts = new HashSet<ActDal>();
			Invoices = new HashSet<InvoiceDal>();
			PromoCodeTypeServices = new HashSet<PromoCodeTypeServiceDal>();
			ServiceHistories = new HashSet<ServiceHistoryDal>();
			Services = new HashSet<ServiceDal>();
			Statistics = new HashSet<StatisticDal>();
			TariffPlanDurations = new HashSet<TariffPlanDurationDal>();
		}

		[Key]
		public long Id { get; set; }
		public decimal ValueWork { get; set; }
		public int PeriodUnitsId { get; set; }

		public PeriodUnitDal PeriodUnits { get; set; }
		public ICollection<ActDal> Acts { get; set; }
		public ICollection<InvoiceDal> Invoices { get; set; }
		public ICollection<PromoCodeTypeServiceDal> PromoCodeTypeServices { get; set; }
		public ICollection<ServiceHistoryDal> ServiceHistories { get; set; }
		public ICollection<ServiceDal> Services { get; set; }
		public ICollection<StatisticDal> Statistics { get; set; }
		public ICollection<TariffPlanDurationDal> TariffPlanDurations { get; set; }
	}
}
