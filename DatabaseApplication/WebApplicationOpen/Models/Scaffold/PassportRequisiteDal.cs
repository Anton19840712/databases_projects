using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("PassportRequisite")]
	public sealed class PassportRequisiteDal
	{
		public PassportRequisiteDal()
		{
			Clients = new HashSet<ClientDal>();
		}

		[Key]
		public long PassportRequisitesId { get; set; }
		public string PassportNumber { get; set; }
		public string PassportIssue { get; set; }
		public string PassportSeries { get; set; }
		public string PassportIssueDate { get; set; }
		public string PassportIdentificationNumber { get; set; }

		public ICollection<ClientDal> Clients { get; set; }
	}
}
