using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class DomainZone
	{
		public DomainZone()
		{
			DomainHistories = new HashSet<DomainHistory>();
			Domains = new HashSet<Domain>();
			Statistics = new HashSet<Statistic>();
			TariffPlans = new HashSet<TariffPlan>();
		}

		public int DomainZoneId { get; set; }
		public string Name { get; set; }
		public string Label { get; set; }
		public bool IsActive { get; set; }

		public virtual ICollection<DomainHistory> DomainHistories { get; set; }
		public virtual ICollection<Domain> Domains { get; set; }
		public virtual ICollection<Statistic> Statistics { get; set; }
		public virtual ICollection<TariffPlan> TariffPlans { get; set; }
	}
}
