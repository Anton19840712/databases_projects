using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("HostingServersIp")]
	public class HostingServersIpDal
	{
		[Key]
		public long HostingServersIpId { get; set; }
		public string Ip { get; set; }
		public long HostingServerId { get; set; }

		public virtual HostingServerDal HostingServer { get; set; }
	}
}
