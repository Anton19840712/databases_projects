using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.Clients
{
	[Table("PassportRequisites")]
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
