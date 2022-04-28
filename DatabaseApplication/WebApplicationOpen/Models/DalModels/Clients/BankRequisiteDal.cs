using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.Clients
{
	[Table("BankRequisites")]
	public sealed class BankRequisiteDal
	{
		public BankRequisiteDal()
		{
			Clients = new HashSet<ClientDal>();
		}

		[Key]
		public long BankRequisitesId { get; set; }
		public string Account { get; set; }
		public string BankName { get; set; }
		public string BankCode { get; set; }
		public string Payer { get; set; }

		public ICollection<ClientDal> Clients { get; set; }
	}
}
