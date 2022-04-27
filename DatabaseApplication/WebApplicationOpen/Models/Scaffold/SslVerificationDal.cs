using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("SslVerification")]
	public class SslVerificationDal
	{
		public int SslVerificationId { get; set; }
		public int SslTariffSettingId { get; set; }
		public int SslVerificationTypeId { get; set; }

		public virtual SslTariffSettingDal SslTariffSetting { get; set; }
		public virtual SslVerificationTypeDal SslVerificationType { get; set; }
	}
}
