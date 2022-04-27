using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("Cost")]
	public sealed class CostDal
	{
		public CostDal()
		{
			Acts = new HashSet<ActDal>();
			Invoices = new HashSet<InvoiceDal>();
			ServiceHistories = new HashSet<ServiceHistoryDal>();
			TariffPlanCosts = new HashSet<TariffPlanCostDal>();
		}

		public long CostId { get; set; }
		public int CurrencyId { get; set; }
		public decimal Value { get; set; }

		public CurrencyDal Currency { get; set; }
		public ICollection<ActDal> Acts { get; set; }
		public ICollection<InvoiceDal> Invoices { get; set; }
		public ICollection<ServiceHistoryDal> ServiceHistories { get; set; }
		public ICollection<TariffPlanCostDal> TariffPlanCosts { get; set; }
	}
}
