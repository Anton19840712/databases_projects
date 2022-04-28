using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.VerificationOfRequisites
{
	[Table("VerificationStatuses")]
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
