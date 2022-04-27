using System;



namespace WebApplicationOpen.Models.Scaffold
{
	public class VerificationLog
	{
		public long VerificationLogId { get; set; }
		public long VerificationResultId { get; set; }
		public DateTime CreationDate { get; set; }
		public string VerificationKey { get; set; }
		public DateTime ExpirationDate { get; set; }
		public bool IsExpired { get; set; }
		public DateTime VerificationDate { get; set; }

		public virtual VerificationResult VerificationResult { get; set; }
	}
}
