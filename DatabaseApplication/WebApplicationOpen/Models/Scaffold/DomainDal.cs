using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("Domain")]
	public sealed class DomainDal
	{
		public DomainDal()
		{
			DnsServers = new HashSet<DnsServerDal>();
			DomainDescendants = new HashSet<DomainDescendantDal>();
			DomainXrrpQueues = new HashSet<DomainXrrpQueueDal>();
			DsRecords = new HashSet<DsRecordDal>();
			Redirects = new HashSet<RedirectDal>();
		}

		[Key]
		public long DomainId { get; set; }
		public long ServiceId { get; set; }
		public int DomainZoneId { get; set; }
		public long? WhoIsInfoId { get; set; }
		public string Name { get; set; }
		public long? RegistrantId { get; set; }
		public bool HasRecords { get; set; }
		public bool HasRedirects { get; set; }

		public DomainZoneDal DomainZone { get; set; }
		public RegistrantDal Registrant { get; set; }
		public ServiceDal Service { get; set; }
		public WhoIsInfoDal WhoIsInfo { get; set; }
		public TransferIncomingRequestDal TransferIncomingRequest { get; set; }
		public ICollection<DnsServerDal> DnsServers { get; set; }
		public ICollection<DomainDescendantDal> DomainDescendants { get; set; }
		public ICollection<DomainXrrpQueueDal> DomainXrrpQueues { get; set; }
		public ICollection<DsRecordDal> DsRecords { get; set; }
		public ICollection<RedirectDal> Redirects { get; set; }
	}
}
