

namespace WebApplicationOpen.Models.Scaffold
{
	public class DnsServer
	{
		public long DnsServerId { get; set; }
		public long DomainId { get; set; }
		public string DnsIp { get; set; }
		public string DnsUrl { get; set; }

		public virtual Domain Domain { get; set; }
	}
}
