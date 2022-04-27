using System;



namespace WebApplicationOpen.Models.Scaffold
{
	public class ActDal
	{
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

		public virtual Cost Cost { get; set; }
		public virtual ClientDal RedelegateClient { get; set; }
		public virtual ServiceHistory ServiceHistory { get; set; }
		public virtual TariffPlan TariffPlan { get; set; }
		public virtual TarifficationAmountWork TarifficationAmountWork { get; set; }
		public virtual Vat Vat { get; set; }
	}
}
