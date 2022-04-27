using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("SslTariffSetting")]
	public sealed class SslTariffSettingDal
	{
		public SslTariffSettingDal()
		{
			SslVerifications = new HashSet<SslVerificationDal>();
		}

		public int SslTariffSettingId { get; set; }
		public long TariffPlanId { get; set; }
		public int SslCertificateTypeId { get; set; }
		public int? DomainsAmmount { get; set; }
		public long? ParentTariffPlanId { get; set; }
		public bool? HasSubDomains { get; set; }
		public bool IsFree { get; set; }

		public TariffPlanDal ParentTariffPlan { get; set; }
		public SslCertificateTypeDal SslCertificateType { get; set; }
		public TariffPlanDal TariffPlan { get; set; }
		public ICollection<SslVerificationDal> SslVerifications { get; set; }
	}
}
