using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("InvoicePaymentRequisite")]
	public class InvoicePaymentRequisiteDal
	{
		[Key]
		public long InvoicePaymentRequsitesId { get; set; }
		public long InvoicePaymentId { get; set; }
		public int CountryId { get; set; }
		public string Address { get; set; }
		public string Payer { get; set; }
		public string Unp { get; set; }
		public string Account { get; set; }
		public string BankName { get; set; }
		public string BankCode { get; set; }

		public virtual CountryDal Country { get; set; }
		public virtual InvoicePaymentDal InvoicePayment { get; set; }
	}
}
