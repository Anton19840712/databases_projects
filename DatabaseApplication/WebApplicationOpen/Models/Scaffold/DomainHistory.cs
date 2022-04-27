using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class DomainHistory
	{
		public DomainHistory()
		{
			DomainLogs = new HashSet<DomainLog>();
			ServiceHistories = new HashSet<ServiceHistory>();
		}

		public long DomainHistoryId { get; set; }
		public int DomainZoneId { get; set; }
		public string Name { get; set; }

		public virtual DomainZone DomainZone { get; set; }
		public virtual ICollection<DomainLog> DomainLogs { get; set; }
		public virtual ICollection<ServiceHistory> ServiceHistories { get; set; }
	}
}
