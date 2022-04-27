using System;
using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class InvoicePayment
	{
		public InvoicePayment()
		{
			InvoicePaymentRequisites = new HashSet<InvoicePaymentRequisite>();
		}

		public long InvoicePaymentId { get; set; }
		public long InvoiceId { get; set; }
		public DateTime PaymentDate { get; set; }
		public DateTime CreationDate { get; set; }
		public DateTime? LastModificationDate { get; set; }
		public string PaymentDocumentNumber { get; set; }
		public string Note { get; set; }
		public long? MemorialOrderNumber { get; set; }

		public virtual Invoice Invoice { get; set; }
		public virtual ICollection<InvoicePaymentRequisite> InvoicePaymentRequisites { get; set; }
	}
}
