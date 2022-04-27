using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("Language")]
	public sealed class LanguageDal
	{
		public LanguageDal()
		{
			TariffPlanInfos = new HashSet<TariffPlanInfoDal>();
		}

		public int LanguageId { get; set; }
		public string Language1 { get; set; }

		public ICollection<TariffPlanInfoDal> TariffPlanInfos { get; set; }
	}
}
