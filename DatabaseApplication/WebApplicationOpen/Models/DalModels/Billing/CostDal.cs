using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.TariffPlans;

namespace WebApplicationOpen.Models.DalModels.Billing
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

		[Key]
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
