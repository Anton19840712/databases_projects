using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.Common;

namespace WebApplicationOpen.Models.DalModels.TariffPlans
{
	[Table("TariffPlanInfos")]
	public class TariffPlanInfoDal
	{
		[Key]
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
