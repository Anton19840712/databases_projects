﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("PromoCodeService")]
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
