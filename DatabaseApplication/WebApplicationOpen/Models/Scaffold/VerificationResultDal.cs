using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("VerificationResult")]
	public sealed class VerificationResultDal
	{
		public VerificationResultDal()
		{
			VerificationLogs = new HashSet<VerificationLogDal>();
		}

		public long VerificationResultId { get; set; }
		public long ClientId { get; set; }
		public int VerificationFieldId { get; set; }
		public int VerificationStatusId { get; set; }

		public ClientDal Client { get; set; }
		public VerificationFieldDal VerificationField { get; set; }
		public VerificationStatusDal VerificationStatus { get; set; }
		public ICollection<VerificationLogDal> VerificationLogs { get; set; }
	}
}
