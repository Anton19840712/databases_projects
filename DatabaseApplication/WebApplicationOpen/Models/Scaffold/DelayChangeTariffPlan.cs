using System;



namespace WebApplicationOpen.Models.Scaffold
{
	public class DelayChangeTariffPlan
	{
		public long Id { get; set; }
		public long ServiceId { get; set; }
		public long ClientId { get; set; }
		public int ChangeType { get; set; }
		public int? Currency { get; set; }
		public decimal? SumNeedForChange { get; set; }
		public DateTime DateChange { get; set; }
		public long TariffPlanId { get; set; }
	}
}
