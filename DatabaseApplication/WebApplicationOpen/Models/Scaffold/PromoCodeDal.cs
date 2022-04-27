﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("PromoCode")]
	public sealed class PromoCodeDal
	{
		public PromoCodeDal()
		{
			Invoices = new HashSet<InvoiceDal>();
			PromoCodeDiscountValues = new HashSet<PromoCodeDiscountValueDal>();
			PromoCodeServices = new HashSet<PromoCodeServiceDal>();
			PromoCodeTypeServices = new HashSet<PromoCodeTypeServiceDal>();
		}

		public long PromoCodeId { get; set; }
		public string Name { get; set; }
		public int PromoCodeBy { get; set; }
		public bool Status { get; set; }
		public DateTime? PeriodStart { get; set; }
		public DateTime? PeriodEnd { get; set; }
		public int PromoCodeDiscountType { get; set; }

		public ICollection<InvoiceDal> Invoices { get; set; }
		public ICollection<PromoCodeDiscountValueDal> PromoCodeDiscountValues { get; set; }
		public ICollection<PromoCodeServiceDal> PromoCodeServices { get; set; }
		public ICollection<PromoCodeTypeServiceDal> PromoCodeTypeServices { get; set; }
	}
}
