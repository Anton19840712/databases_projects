using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class SslVerificationType
	{
		public SslVerificationType()
		{
			SslServices = new HashSet<SslService>();
			SslVerifications = new HashSet<SslVerification>();
		}

		public int SslVerificationTypeId { get; set; }
		public string Description { get; set; }

		public ICollection<SslService> SslServices { get; set; }
		public ICollection<SslVerification> SslVerifications { get; set; }
	}
}
