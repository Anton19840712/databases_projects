

namespace WebApplicationOpen.Models.Scaffold
{
	public class DnsMailRecord
	{
		public int DnsMailRecordId { get; set; }
		public int DnsMailProviderId { get; set; }
		public string DomainName { get; set; }
		public string RecordType { get; set; }
		public int? RecordPriority { get; set; }
		public string RecordValue { get; set; }

		public virtual DnsMailProvider DnsMailProvider { get; set; }
	}
}
