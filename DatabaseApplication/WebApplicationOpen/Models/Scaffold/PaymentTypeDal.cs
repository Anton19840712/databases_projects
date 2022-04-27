using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("PaymentType")]
	public sealed class PaymentTypeDal
	{
		public PaymentTypeDal()
		{
			Invoices = new HashSet<InvoiceDal>();
		}

		public int PaymentTypeId { get; set; }
		public string Description { get; set; }

		public ICollection<InvoiceDal> Invoices { get; set; }
	}
}
