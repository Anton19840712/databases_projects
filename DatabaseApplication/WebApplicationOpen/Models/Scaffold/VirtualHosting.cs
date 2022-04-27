

namespace WebApplicationOpen.Models.Scaffold
{
	public class VirtualHosting
	{
		public long VirtualHostingId { get; set; }
		public long ServiceId { get; set; }
		public bool IsRecovery { get; set; }
		public long? HostingServerId { get; set; }

		public virtual HostingServer HostingServer { get; set; }
		public virtual Service Service { get; set; }
	}
}
