using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.Billing;
using WebApplicationOpen.Models.DalModels.Domains;
using WebApplicationOpen.Models.DalModels.SslCertificates;

namespace WebApplicationOpen.Models.DalModels.Clients
{
	[Table("ClientTypes")]
	public sealed class ClientTypeDal
	{
		public ClientTypeDal()
		{
			ClientBalanceTypes = new HashSet<ClientBalanceTypeDal>();
			ClientInfoForSslOrders = new HashSet<ClientInfoForSslOrderDal>();
			Clients = new HashSet<ClientDal>();
			Registrants = new HashSet<RegistrantDal>();
			SslApiQueues = new HashSet<SslApiQueueDal>();
		}

		[Key]
		public int ClientTypeId { get; set; }
		public string ClientTypeName { get; set; }

		public ICollection<ClientBalanceTypeDal> ClientBalanceTypes { get; set; }
		public ICollection<ClientInfoForSslOrderDal> ClientInfoForSslOrders { get; set; }
		public ICollection<ClientDal> Clients { get; set; }
		public ICollection<RegistrantDal> Registrants { get; set; }
		public ICollection<SslApiQueueDal> SslApiQueues { get; set; }
	}
}
