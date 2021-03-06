using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.BaseTablesForServices;
using WebApplicationOpen.Models.DalModels.Domains;

namespace WebApplicationOpen.Models.DalModels.Clients
{
	[Table("WhoIsInfo")]
	public sealed class WhoIsInfoDal
	{
		public WhoIsInfoDal()
		{
			Clients = new HashSet<ClientDal>();
			Domains = new HashSet<DomainDal>();
			Services = new HashSet<ServiceDal>();
		}

		[Key]
		public long WhoIsInfoId { get; set; }
		public bool? Protected { get; set; }
		public bool? ProtectedPhone { get; set; }

		public ICollection<ClientDal> Clients { get; set; }
		public ICollection<DomainDal> Domains { get; set; }
		public ICollection<ServiceDal> Services { get; set; }
	}
}
