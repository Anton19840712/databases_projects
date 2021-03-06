using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.StateRegistration;

namespace WebApplicationOpen.Models.DalModels.VirtualHosting
{
	[Table("HostingServers")]
	public sealed class HostingServerDal
	{
		public HostingServerDal()
		{
			HostingServersIps = new HashSet<HostingServersIpDal>();
			ServiceRegistrations = new HashSet<ServiceRegistrationDal>();
			VirtualHostings = new HashSet<VirtualHostingDal>();
		}

		[Key]
		public long HostingServerId { get; set; }
		public string Name { get; set; }
		public string Ports { get; set; }
		public string Dcnumber { get; set; }
		public int HostingServerTypeId { get; set; }
		public bool IsDefault { get; set; }
		public string Token { get; set; }
		public string Owner { get; set; }

		public HostingServerTypeDal HostingServerType { get; set; }
		public ICollection<HostingServersIpDal> HostingServersIps { get; set; }
		public ICollection<ServiceRegistrationDal> ServiceRegistrations { get; set; }
		public ICollection<VirtualHostingDal> VirtualHostings { get; set; }
	}
}
