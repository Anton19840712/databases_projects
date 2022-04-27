using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class VerificationResult
	{
		public VerificationResult()
		{
			VerificationLogs = new HashSet<VerificationLog>();
		}

		public long VerificationResultId { get; set; }
		public long ClientId { get; set; }
		public int VerificationFieldId { get; set; }
		public int VerificationStatusId { get; set; }

		public ClientDal Client { get; set; }
		public VerificationField VerificationField { get; set; }
		public VerificationStatus VerificationStatus { get; set; }
		public ICollection<VerificationLog> VerificationLogs { get; set; }
	}
}
