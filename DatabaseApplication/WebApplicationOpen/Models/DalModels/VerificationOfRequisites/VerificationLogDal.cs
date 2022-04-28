using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.VerificationOfRequisites
{
	[Table("VerificationLog")]
	public class VerificationLogDal
	{
		[Key]
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
