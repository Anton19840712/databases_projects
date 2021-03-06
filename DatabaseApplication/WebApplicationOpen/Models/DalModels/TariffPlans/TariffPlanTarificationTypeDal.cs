using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.TariffPlans
{
	[Table("TariffPlanTarificationTypes")]
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
