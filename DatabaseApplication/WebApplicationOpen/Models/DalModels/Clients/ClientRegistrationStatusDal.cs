using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.Clients
{
	[Table("ClientRegistrationStatuses")]
	public sealed class ClientRegistrationStatusDal
	{
		public ClientRegistrationStatusDal()
		{
			Clients = new HashSet<ClientDal>();
		}

		[Key]
		public int ClientRegistrationStatusId { get; set; }
		public string Name { get; set; }

		public ICollection<ClientDal> Clients { get; set; }
	}
}
