

namespace WebApplicationOpen.Models.Scaffold
{
	public class InvoiceEmoneyPayment
	{
		public long InvoiceEmoneyPaymentId { get; set; }
		public long InvoiceId { get; set; }
		public int PaymentStatusId { get; set; }
		public long TransactionId { get; set; }
		public string WalletId { get; set; }

		public virtual Invoice Invoice { get; set; }
		public virtual PaymentStatus PaymentStatus { get; set; }
	}
}
