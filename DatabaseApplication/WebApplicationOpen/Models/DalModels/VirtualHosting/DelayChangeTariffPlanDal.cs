using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.VirtualHosting
{
	[Table("DelayChangeTariffPlan")]
	public class DelayChangeTariffPlanDal
	{
		[Key]
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
