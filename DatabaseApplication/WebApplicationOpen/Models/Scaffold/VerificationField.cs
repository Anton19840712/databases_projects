using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class VerificationField
	{
		public VerificationField()
		{
			VerificationResults = new HashSet<VerificationResult>();
		}

		public int VerificationFieldId { get; set; }
		public string Field { get; set; }

		public ICollection<VerificationResult> VerificationResults { get; set; }
	}
}
