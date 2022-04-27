using System;



namespace WebApplicationOpen.Models.Scaffold
{
	public class PromoCodeService
	{
		public long PromoCodeServiceId { get; set; }
		public long PromoCodeId { get; set; }
		public long? ServiceId { get; set; }
		public long? ShoppingBasketId { get; set; }
		public bool Paid { get; set; }
		public DateTime? DataPaid { get; set; }
		public int PromoCodeBy { get; set; }

		public virtual PromoCode PromoCode { get; set; }
	}
}
