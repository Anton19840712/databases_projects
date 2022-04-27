using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class SslCertificateType
	{
		public SslCertificateType()
		{
			SslApiQueues = new HashSet<SslApiQueue>();
			SslTariffSettings = new HashSet<SslTariffSetting>();
		}

		public int SslCertificateTypeId { get; set; }
		public string Description { get; set; }

		public ICollection<SslApiQueue> SslApiQueues { get; set; }
		public ICollection<SslTariffSetting> SslTariffSettings { get; set; }
	}
}
