using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class HostingServer
	{
		public HostingServer()
		{
			HostingServersIps = new HashSet<HostingServersIp>();
			ServiceRegistrations = new HashSet<ServiceRegistration>();
			VirtualHostings = new HashSet<VirtualHosting>();
		}

		public long HostingServerId { get; set; }
		public string Name { get; set; }
		public string Ports { get; set; }
		public string Dcnumber { get; set; }
		public int HostingServerTypeId { get; set; }
		public bool IsDefault { get; set; }
		public string Token { get; set; }
		public string Owner { get; set; }

		public virtual HostingServerType HostingServerType { get; set; }
		public virtual ICollection<HostingServersIp> HostingServersIps { get; set; }
		public virtual ICollection<ServiceRegistration> ServiceRegistrations { get; set; }
		public virtual ICollection<VirtualHosting> VirtualHostings { get; set; }
	}
}
