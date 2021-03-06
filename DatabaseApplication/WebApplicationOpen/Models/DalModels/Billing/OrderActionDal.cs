using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.SslCertificates;
using WebApplicationOpen.Models.DalModels.TariffPlans;

namespace WebApplicationOpen.Models.DalModels.Billing
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

		[Key]
		public int OrderActionId { get; set; }
		public string Description { get; set; }

		public ICollection<ServiceHistoryDal> ServiceHistories { get; set; }
		public ICollection<SslApiQueueDal> SslApiQueues { get; set; }
		public ICollection<TariffPlanCostDal> TariffPlanCosts { get; set; }
	}
}
