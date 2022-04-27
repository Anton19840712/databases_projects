using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class VerificationStatus
	{
		public VerificationStatus()
		{
			VerificationResults = new HashSet<VerificationResult>();
		}

		public int VerificationStatusId { get; set; }
		public string VerificationStatus1 { get; set; }

		public ICollection<VerificationResult> VerificationResults { get; set; }
	}
}
