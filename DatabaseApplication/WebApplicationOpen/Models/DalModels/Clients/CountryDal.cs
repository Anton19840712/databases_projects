using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.Billing;
using WebApplicationOpen.Models.DalModels.SslCertificates;

namespace WebApplicationOpen.Models.DalModels.Clients
{
	[Table("Countries")]
	public sealed class CountryDal
	{
		public CountryDal()
		{
			Addresses = new HashSet<AddressDal>();
			ClientInfoForSslOrders = new HashSet<ClientInfoForSslOrderDal>();
			ClientRequisitesHistoryCountries = new HashSet<ClientRequisitesHistoryDal>();
			ClientRequisitesHistoryPrimaryAddressCountries = new HashSet<ClientRequisitesHistoryDal>();
			ClientRequisitesHistorySecondaryAddressCountries = new HashSet<ClientRequisitesHistoryDal>();
			Clients = new HashSet<ClientDal>();
			InvoicePaymentRequisites = new HashSet<InvoicePaymentRequisiteDal>();
			SslApiQueues = new HashSet<SslApiQueueDal>();
		}

		[Key]
		public int CountryId { get; set; }
		public string CountryName { get; set; }

		public ICollection<AddressDal> Addresses { get; set; }
		public ICollection<ClientInfoForSslOrderDal> ClientInfoForSslOrders { get; set; }
		public ICollection<ClientRequisitesHistoryDal> ClientRequisitesHistoryCountries { get; set; }   //<---------------------
		public ICollection<ClientRequisitesHistoryDal> ClientRequisitesHistoryPrimaryAddressCountries { get; set; }   //<---------------------
		public ICollection<ClientRequisitesHistoryDal> ClientRequisitesHistorySecondaryAddressCountries { get; set; }
		public ICollection<ClientDal> Clients { get; set; }
		public ICollection<InvoicePaymentRequisiteDal> InvoicePaymentRequisites { get; set; }
		public ICollection<SslApiQueueDal> SslApiQueues { get; set; }
	}
}
