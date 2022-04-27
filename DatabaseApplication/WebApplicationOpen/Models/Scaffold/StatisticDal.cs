using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("Statistic")]
	public class StatisticDal
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
		public virtual DomainZoneDal DomainZone { get; set; }
		public virtual ServiceHistoryDal ServiceHistory { get; set; }
		public virtual TariffPlanDal TariffPlan { get; set; }
		public virtual TarifficationAmountWorkDal TarifficationAmountWork { get; set; }
	}
}
