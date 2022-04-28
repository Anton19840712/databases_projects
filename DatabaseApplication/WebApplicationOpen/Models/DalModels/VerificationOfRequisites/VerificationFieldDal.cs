using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.VerificationOfRequisites
{
	[Table("VerificationFields")]
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
