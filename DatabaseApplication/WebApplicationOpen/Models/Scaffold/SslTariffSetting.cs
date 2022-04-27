using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class SslTariffSetting
	{
		public SslTariffSetting()
		{
			SslVerifications = new HashSet<SslVerification>();
		}

		public int SslTariffSettingId { get; set; }
		public long TariffPlanId { get; set; }
		public int SslCertificateTypeId { get; set; }
		public int? DomainsAmmount { get; set; }
		public long? ParentTariffPlanId { get; set; }
		public bool? HasSubDomains { get; set; }
		public bool IsFree { get; set; }

		public TariffPlan ParentTariffPlan { get; set; }
		public SslCertificateType SslCertificateType { get; set; }
		public TariffPlan TariffPlan { get; set; }
		public ICollection<SslVerification> SslVerifications { get; set; }
	}
}
