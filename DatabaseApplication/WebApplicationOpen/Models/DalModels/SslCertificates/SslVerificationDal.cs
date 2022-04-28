using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.TariffPlans;

namespace WebApplicationOpen.Models.DalModels.SslCertificates
{
	[Table("SslVerifications")]
	public class SslVerificationDal
	{
		[Key]
		public int SslVerificationId { get; set; }
		public int SslTariffSettingId { get; set; }
		public int SslVerificationTypeId { get; set; }

		public virtual SslTariffSettingDal SslTariffSetting { get; set; }
		public virtual SslVerificationTypeDal SslVerificationType { get; set; }
	}
}
