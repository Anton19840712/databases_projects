using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class WhoIsInfo
	{
		public WhoIsInfo()
		{
			Clients = new HashSet<ClientDal>();
			Domains = new HashSet<Domain>();
			Services = new HashSet<Service>();
		}

		public long WhoIsInfoId { get; set; }
		public bool? Protected { get; set; }
		public bool? ProtectedPhone { get; set; }

		public ICollection<ClientDal> Clients { get; set; }
		public ICollection<Domain> Domains { get; set; }
		public ICollection<Service> Services { get; set; }
	}
}
