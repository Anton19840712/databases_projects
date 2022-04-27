using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("DnsServer")]
	public class DnsServerDal
	{
		public long DnsServerId { get; set; }
		public long DomainId { get; set; }
		public string DnsIp { get; set; }
		public string DnsUrl { get; set; }

		public virtual DomainDal Domain { get; set; }
	}
}
