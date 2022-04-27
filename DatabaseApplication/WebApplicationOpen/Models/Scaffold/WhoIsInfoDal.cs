using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
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

		public long WhoIsInfoId { get; set; }
		public bool? Protected { get; set; }
		public bool? ProtectedPhone { get; set; }

		public ICollection<ClientDal> Clients { get; set; }
		public ICollection<DomainDal> Domains { get; set; }
		public ICollection<ServiceDal> Services { get; set; }
	}
}
