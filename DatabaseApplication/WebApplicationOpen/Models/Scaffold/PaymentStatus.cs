using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class PaymentStatus
	{
		public PaymentStatus()
		{
			InvoiceEmoneyPayments = new HashSet<InvoiceEmoneyPayment>();
		}

		public int PaymentStatusId { get; set; }
		public string Description { get; set; }

		public virtual ICollection<InvoiceEmoneyPayment> InvoiceEmoneyPayments { get; set; }
	}
}
