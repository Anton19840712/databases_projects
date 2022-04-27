using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("OrderAction")]
	public sealed class OrderActionDal
	{
		public OrderActionDal()
		{
			ServiceHistories = new HashSet<ServiceHistoryDal>();
			SslApiQueues = new HashSet<SslApiQueueDal>();
			TariffPlanCosts = new HashSet<TariffPlanCostDal>();
		}

		public int OrderActionId { get; set; }
		public string Description { get; set; }

		public ICollection<ServiceHistoryDal> ServiceHistories { get; set; }
		public ICollection<SslApiQueueDal> SslApiQueues { get; set; }
		public ICollection<TariffPlanCostDal> TariffPlanCosts { get; set; }
	}
}
