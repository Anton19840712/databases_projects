using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class DnsMailProvider
	{
		public DnsMailProvider()
		{
			DnsMailRecords = new HashSet<DnsMailRecord>();
		}

		public string ProviderName { get; set; }
		public int DnsMailProviderId { get; set; }

		public virtual ICollection<DnsMailRecord> DnsMailRecords { get; set; }
	}
}
