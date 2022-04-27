using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class EgrRequisite
	{
		public EgrRequisite()
		{
			Clients = new HashSet<ClientDal>();
		}

		public long EgrRequisitesId { get; set; }
		public string Number { get; set; }
		public string Registrar { get; set; }
		public string DecisionNumber { get; set; }
		public string DecisionDate { get; set; }

		public virtual ICollection<ClientDal> Clients { get; set; }
	}
}
