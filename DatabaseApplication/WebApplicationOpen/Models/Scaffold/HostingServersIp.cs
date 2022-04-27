

namespace WebApplicationOpen.Models.Scaffold
{
	public class HostingServersIp
	{
		public long HostingServersIpId { get; set; }
		public string Ip { get; set; }
		public long HostingServerId { get; set; }

		public virtual HostingServer HostingServer { get; set; }
	}
}
