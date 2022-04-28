using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.Billing
{
	[Table("PaymentStatus")]
	public sealed class PaymentStatusDal
	{
		public PaymentStatusDal()
		{
			InvoiceEmoneyPayments = new HashSet<InvoiceEmoneyPaymentDal>();
		}

		[Key]
		public int PaymentStatusId { get; set; }
		public string Description { get; set; }

		public ICollection<InvoiceEmoneyPaymentDal> InvoiceEmoneyPayments { get; set; }
	}
}
