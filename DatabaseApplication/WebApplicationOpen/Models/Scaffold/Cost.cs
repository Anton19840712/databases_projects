using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class Cost
	{
		public Cost()
		{
			Acts = new HashSet<ActDal>();
			Invoices = new HashSet<Invoice>();
			ServiceHistories = new HashSet<ServiceHistory>();
			TariffPlanCosts = new HashSet<TariffPlanCost>();
		}

		public long CostId { get; set; }
		public int CurrencyId { get; set; }
		public decimal Value { get; set; }

		public virtual Currency Currency { get; set; }
		public virtual ICollection<ActDal> Acts { get; set; }
		public virtual ICollection<Invoice> Invoices { get; set; }
		public virtual ICollection<ServiceHistory> ServiceHistories { get; set; }
		public virtual ICollection<TariffPlanCost> TariffPlanCosts { get; set; }
	}
}
