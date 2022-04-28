using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.Domains
{
	[Table("DnsMailProviders")]
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
