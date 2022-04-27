using System;



namespace WebApplicationOpen.Models.Scaffold
{
	public class Statistic
	{
		public long StatisticId { get; set; }
		public long ClientId { get; set; }
		public long TariffPlanId { get; set; }
		public int ActionTypeId { get; set; }
		public DateTime ActionDate { get; set; }
		public string DomainName { get; set; }
		public int? DomainZoneId { get; set; }
		public long? ServiceHistoryId { get; set; }
		public int DurationMonthes { get; set; }
		public long? TarifficationAmountWorkId { get; set; }

		public virtual ActionTypeDal ActionType { get; set; }
		public virtual ClientDal Client { get; set; }
		public virtual DomainZone DomainZone { get; set; }
		public virtual ServiceHistory ServiceHistory { get; set; }
		public virtual TariffPlan TariffPlan { get; set; }
		public virtual TarifficationAmountWork TarifficationAmountWork { get; set; }
	}
}
