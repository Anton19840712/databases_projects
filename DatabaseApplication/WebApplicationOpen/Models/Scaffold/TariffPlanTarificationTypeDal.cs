using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("TariffPlanTarificationType")]
	public sealed class TariffPlanTarificationTypeDal
	{
		public TariffPlanTarificationTypeDal()
		{
			TariffPlans = new HashSet<TariffPlanDal>();
		}

		[Key]
		public int TariffPlanTarificationTypeId { get; set; }
		public string Value { get; set; }

		public ICollection<TariffPlanDal> TariffPlans { get; set; }
	}
}
