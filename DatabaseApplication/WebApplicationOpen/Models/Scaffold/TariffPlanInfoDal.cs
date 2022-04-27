using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("TariffPlanInfo")]
	public class TariffPlanInfoDal
	{
		public long TariffPlanInfoId { get; set; }
		public long TariffPlanId { get; set; }
		public int LanguageId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string SpaceSize { get; set; }
		public string ToolTipDiscription { get; set; }

		public virtual LanguageDal Language { get; set; }
		public virtual TariffPlanDal TariffPlan { get; set; }
	}
}
