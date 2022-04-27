using System;
using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class PromoCode
	{
		public PromoCode()
		{
			Invoices = new HashSet<Invoice>();
			PromoCodeDiscountValues = new HashSet<PromoCodeDiscountValue>();
			PromoCodeServices = new HashSet<PromoCodeService>();
			PromoCodeTypeServices = new HashSet<PromoCodeTypeService>();
		}

		public long PromoCodeId { get; set; }
		public string Name { get; set; }
		public int PromoCodeBy { get; set; }
		public bool Status { get; set; }
		public DateTime? PeriodStart { get; set; }
		public DateTime? PeriodEnd { get; set; }
		public int PromoCodeDiscountType { get; set; }

		public virtual ICollection<Invoice> Invoices { get; set; }
		public virtual ICollection<PromoCodeDiscountValue> PromoCodeDiscountValues { get; set; }
		public virtual ICollection<PromoCodeService> PromoCodeServices { get; set; }
		public virtual ICollection<PromoCodeTypeService> PromoCodeTypeServices { get; set; }
	}
}
