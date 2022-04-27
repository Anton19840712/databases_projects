

namespace WebApplicationOpen.Models.Scaffold
{
	public class PromoCodeDiscountValue
	{
		public long PromoCodeDiscountValueId { get; set; }
		public long PromoCodeId { get; set; }
		public decimal Discount { get; set; }
		public int PromoCodeDiscountType { get; set; }
		public int? CurrencyId { get; set; }
		public bool Delete { get; set; }

		public virtual Currency Currency { get; set; }
		public virtual PromoCode PromoCode { get; set; }
	}
}
