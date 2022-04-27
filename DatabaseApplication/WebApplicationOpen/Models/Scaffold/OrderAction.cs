using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class OrderAction
	{
		public OrderAction()
		{
			ServiceHistories = new HashSet<ServiceHistory>();
			SslApiQueues = new HashSet<SslApiQueue>();
			TariffPlanCosts = new HashSet<TariffPlanCost>();
		}

		public int OrderActionId { get; set; }
		public string Description { get; set; }

		public virtual ICollection<ServiceHistory> ServiceHistories { get; set; }
		public virtual ICollection<SslApiQueue> SslApiQueues { get; set; }
		public virtual ICollection<TariffPlanCost> TariffPlanCosts { get; set; }
	}
}
