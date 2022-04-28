using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("VerificationField")]
	public sealed class VerificationFieldDal
	{
		public VerificationFieldDal()
		{
			VerificationResults = new HashSet<VerificationResultDal>();
		}

		[Key]
		public int VerificationFieldId { get; set; }
		public string Field { get; set; }

		public ICollection<VerificationResultDal> VerificationResults { get; set; }
	}
}
