using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.Clients;
using WebApplicationOpen.Models.DalModels.PromoCodes;
using WebApplicationOpen.Models.DalModels.Vps;

namespace WebApplicationOpen.Models.DalModels.Billing
{
	[Table("Currency")]
	public sealed class CurrencyDal
	{
		public CurrencyDal()
		{
			BalanceTypes = new HashSet<BalanceTypeDal>();
			Clients = new HashSet<ClientDal>();
			Costs = new HashSet<CostDal>();
			PromoCodeDiscountValues = new HashSet<PromoCodeDiscountValueDal>();
			VpsConfigItemsCosts = new HashSet<VpsConfigItemsCostDal>();
		}
		[Key]
		public int CurrencyId { get; set; }
		public string CurrencyName { get; set; }
		public bool? IsArchive { get; set; }

		public ICollection<BalanceTypeDal> BalanceTypes { get; set; }
		public ICollection<ClientDal> Clients { get; set; }
		public ICollection<CostDal> Costs { get; set; }
		public ICollection<PromoCodeDiscountValueDal> PromoCodeDiscountValues { get; set; }
		public ICollection<VpsConfigItemsCostDal> VpsConfigItemsCosts { get; set; }
	}
}
