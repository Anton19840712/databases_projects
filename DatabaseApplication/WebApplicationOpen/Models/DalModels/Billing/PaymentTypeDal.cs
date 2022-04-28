using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.Billing
{
	[Table("PaymentType")]
	public sealed class PaymentTypeDal
	{
		public PaymentTypeDal()
		{
			Invoices = new HashSet<InvoiceDal>();
		}

		[Key]
		public int PaymentTypeId { get; set; }
		public string Description { get; set; }

		public ICollection<InvoiceDal> Invoices { get; set; }
	}
}
