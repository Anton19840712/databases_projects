using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class Currency
	{
		public Currency()
		{
			BalanceTypes = new HashSet<BalanceTypeDal>();
			Clients = new HashSet<ClientDal>();
			Costs = new HashSet<Cost>();
			PromoCodeDiscountValues = new HashSet<PromoCodeDiscountValue>();
			VpsConfigItemsCosts = new HashSet<VpsConfigItemsCost>();
		}

		public int CurrencyId { get; set; }
		public string CurrencyName { get; set; }
		public bool? IsArchive { get; set; }

		public virtual ICollection<BalanceTypeDal> BalanceTypes { get; set; }
		public virtual ICollection<ClientDal> Clients { get; set; }
		public virtual ICollection<Cost> Costs { get; set; }
		public virtual ICollection<PromoCodeDiscountValue> PromoCodeDiscountValues { get; set; }
		public virtual ICollection<VpsConfigItemsCost> VpsConfigItemsCosts { get; set; }
	}
}
