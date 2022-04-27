using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class Domain
	{
		public Domain()
		{
			DnsServers = new HashSet<DnsServer>();
			DomainDescendants = new HashSet<DomainDescendant>();
			DomainXrrpQueues = new HashSet<DomainXrrpQueue>();
			DsRecords = new HashSet<DsRecord>();
			Redirects = new HashSet<Redirect>();
		}

		public long DomainId { get; set; }
		public long ServiceId { get; set; }
		public int DomainZoneId { get; set; }
		public long? WhoIsInfoId { get; set; }
		public string Name { get; set; }
		public long? RegistrantId { get; set; }
		public bool HasRecords { get; set; }
		public bool HasRedirects { get; set; }

		public virtual DomainZone DomainZone { get; set; }
		public virtual Registrant Registrant { get; set; }
		public virtual Service Service { get; set; }
		public virtual WhoIsInfo WhoIsInfo { get; set; }
		public virtual TransferIncomingRequest TransferIncomingRequest { get; set; }
		public virtual ICollection<DnsServer> DnsServers { get; set; }
		public virtual ICollection<DomainDescendant> DomainDescendants { get; set; }
		public virtual ICollection<DomainXrrpQueue> DomainXrrpQueues { get; set; }
		public virtual ICollection<DsRecord> DsRecords { get; set; }
		public virtual ICollection<Redirect> Redirects { get; set; }
	}
}
