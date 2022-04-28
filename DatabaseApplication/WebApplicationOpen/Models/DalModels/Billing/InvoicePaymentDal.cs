using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.Billing
{
	[Table("InvoicePayment")]
	public sealed class InvoicePaymentDal
	{
		public InvoicePaymentDal()
		{
			InvoicePaymentRequisites = new HashSet<InvoicePaymentRequisiteDal>();
		}

		[Key]
		public long InvoicePaymentId { get; set; }
		public long InvoiceId { get; set; }
		public DateTime PaymentDate { get; set; }
		public DateTime CreationDate { get; set; }
		public DateTime? LastModificationDate { get; set; }
		public string PaymentDocumentNumber { get; set; }
		public string Note { get; set; }
		public long? MemorialOrderNumber { get; set; }

		public InvoiceDal Invoice { get; set; }
		public ICollection<InvoicePaymentRequisiteDal> InvoicePaymentRequisites { get; set; }
	}
}
