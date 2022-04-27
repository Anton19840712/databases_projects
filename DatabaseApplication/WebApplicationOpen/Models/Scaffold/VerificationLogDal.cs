using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("VerificationLog")]
	public class VerificationLogDal
	{
		public long VerificationLogId { get; set; }
		public long VerificationResultId { get; set; }
		public DateTime CreationDate { get; set; }
		public string VerificationKey { get; set; }
		public DateTime ExpirationDate { get; set; }
		public bool IsExpired { get; set; }
		public DateTime VerificationDate { get; set; }

		public virtual VerificationResultDal VerificationResult { get; set; }
	}
}
