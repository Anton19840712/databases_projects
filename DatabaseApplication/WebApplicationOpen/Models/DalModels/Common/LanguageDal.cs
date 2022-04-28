using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.TariffPlans;

namespace WebApplicationOpen.Models.DalModels.Common
{
	[Table("Languages")]
	public sealed class LanguageDal
	{
		public LanguageDal()
		{
			TariffPlanInfos = new HashSet<TariffPlanInfoDal>();
		}

		[Key]
		public int LanguageId { get; set; }
		public string Language1 { get; set; }

		public ICollection<TariffPlanInfoDal> TariffPlanInfos { get; set; }
	}
}
