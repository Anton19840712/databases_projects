using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class BankRequisiteDal
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

		public virtual ICollection<ClientDal> Clients { get; set; }
	}
}
