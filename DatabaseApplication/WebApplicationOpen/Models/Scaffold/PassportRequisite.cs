using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class PassportRequisite
	{
		public PassportRequisite()
		{
			Clients = new HashSet<ClientDal>();
		}

		public long PassportRequisitesId { get; set; }
		public string PassportNumber { get; set; }
		public string PassportIssue { get; set; }
		public string PassportSeries { get; set; }
		public string PassportIssueDate { get; set; }
		public string PassportIdentificationNumber { get; set; }

		public virtual ICollection<ClientDal> Clients { get; set; }
	}
}
