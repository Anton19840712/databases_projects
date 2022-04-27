using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class ContactRequisite
	{
		public ContactRequisite()
		{
			Clients = new HashSet<ClientDal>();
		}

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

		public virtual ICollection<ClientDal> Clients { get; set; }
	}
}
