using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("SslCertificateType")]
	public sealed class SslCertificateTypeDal
	{
		public SslCertificateTypeDal()
		{
			SslApiQueues = new HashSet<SslApiQueueDal>();
			SslTariffSettings = new HashSet<SslTariffSettingDal>();
		}

		public int SslCertificateTypeId { get; set; }
		public string Description { get; set; }

		public ICollection<SslApiQueueDal> SslApiQueues { get; set; }
		public ICollection<SslTariffSettingDal> SslTariffSettings { get; set; }
	}
}
