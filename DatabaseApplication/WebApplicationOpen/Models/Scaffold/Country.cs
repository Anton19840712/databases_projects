using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class Country
	{
		public Country()
		{
			Addresses = new HashSet<AddressDal>();
			ClientInfoForSslOrders = new HashSet<ClientInfoForSslOrderDal>();
			ClientRequisitesHistoryCountries = new HashSet<ClientRequisitesHistory>();
			ClientRequisitesHistoryPrimaryAddressCountries = new HashSet<ClientRequisitesHistory>();
			ClientRequisitesHistorySecondaryAddressCountries = new HashSet<ClientRequisitesHistory>();
			Clients = new HashSet<ClientDal>();
			InvoicePaymentRequisites = new HashSet<InvoicePaymentRequisite>();
			SslApiQueues = new HashSet<SslApiQueue>();
		}

		public int CountryId { get; set; }
		public string CountryName { get; set; }

		public ICollection<AddressDal> Addresses { get; set; }
		public ICollection<ClientInfoForSslOrderDal> ClientInfoForSslOrders { get; set; }
		public ICollection<ClientRequisitesHistory> ClientRequisitesHistoryCountries { get; set; }   //<---------------------
		public ICollection<ClientRequisitesHistory> ClientRequisitesHistoryPrimaryAddressCountries { get; set; }   //<---------------------
		public ICollection<ClientRequisitesHistory> ClientRequisitesHistorySecondaryAddressCountries { get; set; }
		public ICollection<ClientDal> Clients { get; set; }
		public ICollection<InvoicePaymentRequisite> InvoicePaymentRequisites { get; set; }
		public ICollection<SslApiQueue> SslApiQueues { get; set; }
	}
}
