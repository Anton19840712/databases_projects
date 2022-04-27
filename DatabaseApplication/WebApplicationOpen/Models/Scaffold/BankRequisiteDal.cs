using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("BankRequisite")]
	public sealed class BankRequisiteDal
	{
		public BankRequisiteDal()
		{
			Clients = new HashSet<ClientDal>();
		}

		public long BankRequisitesId { get; set; }
		public string Account { get; set; }
		public string BankName { get; set; }
		public string BankCode { get; set; }
		public string Payer { get; set; }

		public ICollection<ClientDal> Clients { get; set; }
	}
}
