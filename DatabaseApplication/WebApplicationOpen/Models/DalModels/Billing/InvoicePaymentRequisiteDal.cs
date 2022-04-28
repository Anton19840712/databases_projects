using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.Clients;

namespace WebApplicationOpen.Models.DalModels.Billing
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
