using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("DnsMailProvider")]
	public sealed class DnsMailProviderDal
	{
		public DnsMailProviderDal()
		{
			DnsMailRecords = new HashSet<DnsMailRecordDal>();
		}

		[Key]
		public string ProviderName { get; set; }
		public int DnsMailProviderId { get; set; }

		public ICollection<DnsMailRecordDal> DnsMailRecords { get; set; }
	}
}
