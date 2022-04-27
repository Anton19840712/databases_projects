using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("DnsMailProvider")]
	public sealed class DnsMailProviderDal
	{
		public DnsMailProviderDal()
		{
			DnsMailRecords = new HashSet<DnsMailRecordDal>();
		}

		public string ProviderName { get; set; }
		public int DnsMailProviderId { get; set; }

		public ICollection<DnsMailRecordDal> DnsMailRecords { get; set; }
	}
}
