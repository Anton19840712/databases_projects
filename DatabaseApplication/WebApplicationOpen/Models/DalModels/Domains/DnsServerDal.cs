using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.Domains
{
	[Table("DnsServers")]
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
