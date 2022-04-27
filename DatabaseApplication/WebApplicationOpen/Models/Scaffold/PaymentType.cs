using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class PaymentType
	{
		public PaymentType()
		{
			Invoices = new HashSet<Invoice>();
		}

		public int PaymentTypeId { get; set; }
		public string Description { get; set; }

		public virtual ICollection<Invoice> Invoices { get; set; }
	}
}
