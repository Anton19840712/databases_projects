using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("ContactRequisite")]
	public sealed class ContactRequisiteDal
	{
		public ContactRequisiteDal()
		{
			Clients = new HashSet<ClientDal>();
		}

		[Key]
		public long ContactRequisiteId { get; set; }
		public string Phone { get; set; }
		public string Fax { get; set; }
		public string Email { get; set; }
		public string AdditionalEmail1 { get; set; }
		public string AdditionalEmail2 { get; set; }
		public string AdditionalEmail3 { get; set; }
		public string CpanelEmail { get; set; }
		public string AdditionalPhone1 { get; set; }
		public string AdditionalPhone2 { get; set; }

		public ICollection<ClientDal> Clients { get; set; }
	}
}
