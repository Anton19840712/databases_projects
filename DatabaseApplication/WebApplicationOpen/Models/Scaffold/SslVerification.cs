

namespace WebApplicationOpen.Models.Scaffold
{
	public class SslVerification
	{
		public int SslVerificationId { get; set; }
		public int SslTariffSettingId { get; set; }
		public int SslVerificationTypeId { get; set; }

		public virtual SslTariffSetting SslTariffSetting { get; set; }
		public virtual SslVerificationType SslVerificationType { get; set; }
	}
}
