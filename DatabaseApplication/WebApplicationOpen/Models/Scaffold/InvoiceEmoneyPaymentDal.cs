using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("InvoiceEmoneyPayment")]
	public class InvoiceEmoneyPaymentDal
	{
		[Key]
		public long InvoiceEmoneyPaymentId { get; set; }
		public long InvoiceId { get; set; }
		public int PaymentStatusId { get; set; }
		public long TransactionId { get; set; }
		public string WalletId { get; set; }

		public virtual InvoiceDal Invoice { get; set; }
		public virtual PaymentStatusDal PaymentStatus { get; set; }
	}
}
