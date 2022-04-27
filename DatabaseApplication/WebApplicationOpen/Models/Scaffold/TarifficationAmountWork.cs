using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class TarifficationAmountWork
	{
		public TarifficationAmountWork()
		{
			Acts = new HashSet<ActDal>();
			Invoices = new HashSet<Invoice>();
			PromoCodeTypeServices = new HashSet<PromoCodeTypeService>();
			ServiceHistories = new HashSet<ServiceHistory>();
			Services = new HashSet<Service>();
			Statistics = new HashSet<Statistic>();
			TariffPlanDurations = new HashSet<TariffPlanDuration>();
		}

		public long Id { get; set; }
		public decimal ValueWork { get; set; }
		public int PeriodUnitsId { get; set; }

		public PeriodUnit PeriodUnits { get; set; }
		public ICollection<ActDal> Acts { get; set; }
		public ICollection<Invoice> Invoices { get; set; }
		public ICollection<PromoCodeTypeService> PromoCodeTypeServices { get; set; }
		public ICollection<ServiceHistory> ServiceHistories { get; set; }
		public ICollection<Service> Services { get; set; }
		public ICollection<Statistic> Statistics { get; set; }
		public ICollection<TariffPlanDuration> TariffPlanDurations { get; set; }
	}
}
