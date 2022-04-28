using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.VirtualHosting
{
	[Table("HostingServersIps")]
	public class HostingServersIpDal
	{
		[Key]
		public long HostingServersIpId { get; set; }
		public string Ip { get; set; }
		public long HostingServerId { get; set; }

		public virtual HostingServerDal HostingServer { get; set; }
	}
}
