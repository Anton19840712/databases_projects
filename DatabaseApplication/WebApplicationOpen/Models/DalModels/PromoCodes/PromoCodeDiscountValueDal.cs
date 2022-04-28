using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.Billing;

namespace WebApplicationOpen.Models.DalModels.PromoCodes
{
	[Table("PromoCodeDiscountValues")]
	public class PromoCodeDiscountValueDal
	{
		[Key]
		public long PromoCodeDiscountValueId { get; set; }
		public long PromoCodeId { get; set; }
		public decimal Discount { get; set; }
		public int PromoCodeDiscountType { get; set; }
		public int? CurrencyId { get; set; }
		public bool Delete { get; set; }

		public virtual CurrencyDal Currency { get; set; }
		public virtual PromoCodeDal PromoCode { get; set; }
	}
}
