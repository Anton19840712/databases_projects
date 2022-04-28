using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.Domains
{
	[Table("DnsMailRecords")]
	public class DnsMailRecordDal
	{
		[Key]
		public int DnsMailRecordId { get; set; }
		public int DnsMailProviderId { get; set; }
		public string DomainName { get; set; }
		public string RecordType { get; set; }
		public int? RecordPriority { get; set; }
		public string RecordValue { get; set; }

		public virtual DnsMailProviderDal DnsMailProvider { get; set; }
	}
}
