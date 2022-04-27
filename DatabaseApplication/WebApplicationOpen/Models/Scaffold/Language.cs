using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class Language
	{
		public Language()
		{
			TariffPlanInfos = new HashSet<TariffPlanInfo>();
		}

		public int LanguageId { get; set; }
		public string Language1 { get; set; }

		public virtual ICollection<TariffPlanInfo> TariffPlanInfos { get; set; }
	}
}
