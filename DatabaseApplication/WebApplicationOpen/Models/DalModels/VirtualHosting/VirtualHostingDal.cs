using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.BaseTablesForServices;

namespace WebApplicationOpen.Models.DalModels.VirtualHosting
{
	[Table("VirtualHosting")]
	public class VirtualHostingDal
	{
		[Key]
		public long VirtualHostingId { get; set; }
		public long ServiceId { get; set; }
		public bool IsRecovery { get; set; }
		public long? HostingServerId { get; set; }

		public virtual HostingServerDal HostingServer { get; set; }
		public virtual ServiceDal Service { get; set; }
	}
}
