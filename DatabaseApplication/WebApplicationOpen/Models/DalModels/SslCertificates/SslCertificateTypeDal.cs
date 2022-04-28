using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.TariffPlans;

namespace WebApplicationOpen.Models.DalModels.SslCertificates
{
	[Table("SslCertificateTypes")]
	public sealed class SslCertificateTypeDal
	{
		public SslCertificateTypeDal()
		{
			SslApiQueues = new HashSet<SslApiQueueDal>();
			SslTariffSettings = new HashSet<SslTariffSettingDal>();
		}

		[Key]
		public int SslCertificateTypeId { get; set; }
		public string Description { get; set; }

		public ICollection<SslApiQueueDal> SslApiQueues { get; set; }
		public ICollection<SslTariffSettingDal> SslTariffSettings { get; set; }
	}
}
