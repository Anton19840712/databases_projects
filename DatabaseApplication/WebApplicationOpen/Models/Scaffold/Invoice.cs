using System;



namespace WebApplicationOpen.Models.Scaffold
{
	public class Invoice
	{
		public long InvoiceId { get; set; }
		public long UniqueId { get; set; }
		public long CostId { get; set; }
		public long ClientId { get; set; }
		public bool IsPayed { get; set; }
		public DateTime CreationDate { get; set; }
		public DateTime ExpirationDate { get; set; }
		public int PaymentTypeId { get; set; }
		public string AccessKey { get; set; }
		public string DomainName { get; set; }
		public long? ServiceId { get; set; }
		public int? Discount { get; set; }
		public int? Duration { get; set; }
		public int? OrderActionId { get; set; }
		public long? TariffPlanId { get; set; }
		public long? TarifficationAmountWorkId { get; set; }
		public long? PromoCodeId { get; set; }

		public virtual ClientDal Client { get; set; }
		public virtual Cost Cost { get; set; }
		public virtual PaymentType PaymentType { get; set; }
		public virtual PromoCode PromoCode { get; set; }
		public virtual TarifficationAmountWork TarifficationAmountWork { get; set; }
		public virtual InvoiceEmoneyPayment InvoiceEmoneyPayment { get; set; }
		public virtual InvoicePayment InvoicePayment { get; set; }
	}
}
