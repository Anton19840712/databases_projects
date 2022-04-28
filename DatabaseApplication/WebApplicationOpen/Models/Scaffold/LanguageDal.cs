using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("Language")]
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
