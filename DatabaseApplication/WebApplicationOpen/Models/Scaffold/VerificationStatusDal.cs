using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("VerificationStatus")]
	public sealed class VerificationStatusDal
	{
		public VerificationStatusDal()
		{
			VerificationResults = new HashSet<VerificationResultDal>();
		}

		public int VerificationStatusId { get; set; }
		public string VerificationStatus1 { get; set; }

		public ICollection<VerificationResultDal> VerificationResults { get; set; }
	}
}
