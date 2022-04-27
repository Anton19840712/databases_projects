using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class ClientType
	{
		public ClientType()
		{
			ClientBalanceTypes = new HashSet<ClientBalanceTypeDal>();
			ClientInfoForSslOrders = new HashSet<ClientInfoForSslOrderDal>();
			Clients = new HashSet<ClientDal>();
			Registrants = new HashSet<Registrant>();
			SslApiQueues = new HashSet<SslApiQueue>();
		}

		public int ClientTypeId { get; set; }
		public string ClientTypeName { get; set; }

		public virtual ICollection<ClientBalanceTypeDal> ClientBalanceTypes { get; set; }
		public virtual ICollection<ClientInfoForSslOrderDal> ClientInfoForSslOrders { get; set; }
		public virtual ICollection<ClientDal> Clients { get; set; }
		public virtual ICollection<Registrant> Registrants { get; set; }
		public virtual ICollection<SslApiQueue> SslApiQueues { get; set; }
	}
}
