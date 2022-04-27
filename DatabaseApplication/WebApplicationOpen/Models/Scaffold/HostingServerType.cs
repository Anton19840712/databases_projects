using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class HostingServerType
	{
		public HostingServerType()
		{
			HostingServers = new HashSet<HostingServer>();
		}

		public int HostingServerTypeId { get; set; }
		public string Name { get; set; }

		public virtual ICollection<HostingServer> HostingServers { get; set; }
	}
}
