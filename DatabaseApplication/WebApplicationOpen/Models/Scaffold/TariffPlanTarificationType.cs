using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class TariffPlanTarificationType
	{
		public TariffPlanTarificationType()
		{
			TariffPlans = new HashSet<TariffPlan>();
		}

		public int TariffPlanTarificationTypeId { get; set; }
		public string Value { get; set; }

		public ICollection<TariffPlan> TariffPlans { get; set; }
	}
}
