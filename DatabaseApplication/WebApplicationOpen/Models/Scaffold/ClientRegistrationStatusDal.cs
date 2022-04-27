using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("ClientRegistrationStatus")]
	public sealed class ClientRegistrationStatusDal
	{
		public ClientRegistrationStatusDal()
		{
			Clients = new HashSet<ClientDal>();
		}

		public int ClientRegistrationStatusId { get; set; }
		public string Name { get; set; }

		public ICollection<ClientDal> Clients { get; set; }
	}
}
