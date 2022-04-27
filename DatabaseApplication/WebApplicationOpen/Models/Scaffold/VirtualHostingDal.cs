using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("VirtualHosting")]
	public class VirtualHostingDal
	{
		public long VirtualHostingId { get; set; }
		public long ServiceId { get; set; }
		public bool IsRecovery { get; set; }
		public long? HostingServerId { get; set; }

		public virtual HostingServerDal HostingServer { get; set; }
		public virtual ServiceDal Service { get; set; }
	}
}
