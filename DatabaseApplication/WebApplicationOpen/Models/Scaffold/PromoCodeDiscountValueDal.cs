using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("PromoCodeDiscountValue")]
	public class PromoCodeDiscountValueDal
	{
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
