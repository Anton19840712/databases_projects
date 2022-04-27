using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("EgrRequisite")]
	public sealed class EgrRequisiteDal
	{
		public EgrRequisiteDal()
		{
			Clients = new HashSet<ClientDal>();
		}

		public long EgrRequisitesId { get; set; }
		public string Number { get; set; }
		public string Registrar { get; set; }
		public string DecisionNumber { get; set; }
		public string DecisionDate { get; set; }

		public ICollection<ClientDal> Clients { get; set; }
	}
}
