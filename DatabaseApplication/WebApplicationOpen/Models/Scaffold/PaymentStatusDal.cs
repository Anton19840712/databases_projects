using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
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
