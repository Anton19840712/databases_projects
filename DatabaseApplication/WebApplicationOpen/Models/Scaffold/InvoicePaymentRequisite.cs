

namespace WebApplicationOpen.Models.Scaffold
{
	public class InvoicePaymentRequisite
	{
		public long InvoicePaymentRequsitesId { get; set; }
		public long InvoicePaymentId { get; set; }
		public int CountryId { get; set; }
		public string Address { get; set; }
		public string Payer { get; set; }
		public string Unp { get; set; }
		public string Account { get; set; }
		public string BankName { get; set; }
		public string BankCode { get; set; }

		public virtual Country Country { get; set; }
		public virtual InvoicePayment InvoicePayment { get; set; }
	}
}
