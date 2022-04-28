using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("DnsServer")]
	public class DnsServerDal
	{
		[Key]
		public long DnsServerId { get; set; }
		public long DomainId { get; set; }
		public string DnsIp { get; set; }
		public string DnsUrl { get; set; }

		public virtual DomainDal Domain { get; set; }
	}
}
