using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.SslCertificates;

namespace WebApplicationOpen.Models.DalModels.TariffPlans
{
	[Table("SslTariffSettings")]
	public sealed class SslTariffSettingDal
	{
		public SslTariffSettingDal()
		{
			SslVerifications = new HashSet<SslVerificationDal>();
		}

		[Key]
		public int SslTariffSettingId { get; set; }
		public long TariffPlanId { get; set; }
		public int SslCertificateTypeId { get; set; }
		public int? DomainsAmmount { get; set; }
		public long? ParentTariffPlanId { get; set; }
		public bool? HasSubDomains { get; set; }
		public bool IsFree { get; set; }

		[NotMapped]
		public TariffPlanDal ParentTariffPlan { get; set; }
		public SslCertificateTypeDal SslCertificateType { get; set; }

		[NotMapped]
		public TariffPlanDal TariffPlan { get; set; }
		public ICollection<SslVerificationDal> SslVerifications { get; set; }
	}
}
