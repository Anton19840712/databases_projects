using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.Clients;
using WebApplicationOpen.Models.DalModels.TariffPlans;

namespace WebApplicationOpen.Models.DalModels.Billing
{
	[Table("Act")]
	public class ActDal
	{
		[Key]
		public long ActId { get; set; }
		public long ServiceHistoryId { get; set; }
		public long CostId { get; set; }
		public long VatId { get; set; }
		public long TariffPlanId { get; set; }
		public DateTime ReportDate { get; set; }
		public DateTime ActivationDate { get; set; }
		public int DurationDays { get; set; }
		public int Discount { get; set; }
		public decimal? ReservedBalanceByService { get; set; }
		public long? TarifficationAmountWorkId { get; set; }
		public bool? RedelegateAct { get; set; }
		public long? RedelegateClientId { get; set; }

		public virtual CostDal Cost { get; set; }
		public virtual ClientDal RedelegateClient { get; set; }
		public virtual ServiceHistoryDal ServiceHistory { get; set; }
		public virtual TariffPlanDal TariffPlan { get; set; }
		public virtual TarifficationAmountWorkDal TarifficationAmountWork { get; set; }
		public virtual VatDal Vat { get; set; }
	}
}
