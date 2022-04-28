using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.PromoCodes
{
	[Table("PromoCodeServices")]
	public class PromoCodeServiceDal
	{
		[Key]
		public long PromoCodeServiceId { get; set; }
		public long PromoCodeId { get; set; }
		public long? ServiceId { get; set; }
		public long? ShoppingBasketId { get; set; }
		public bool Paid { get; set; }
		public DateTime? DataPaid { get; set; }
		public int PromoCodeBy { get; set; }

		public virtual PromoCodeDal PromoCode { get; set; }
	}
}
