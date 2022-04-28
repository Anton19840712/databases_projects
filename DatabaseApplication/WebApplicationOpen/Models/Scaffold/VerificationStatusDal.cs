using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("VerificationStatus")]
	public sealed class VerificationStatusDal
	{
		public VerificationStatusDal()
		{
			VerificationResults = new HashSet<VerificationResultDal>();
		}

		[Key]
		public int VerificationStatusId { get; set; }
		public string VerificationStatus1 { get; set; }

		public ICollection<VerificationResultDal> VerificationResults { get; set; }
	}
}
