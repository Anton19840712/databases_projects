using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class ClientRegistrationStatusDal
	{
		public ClientRegistrationStatusDal()
		{
			Clients = new HashSet<ClientDal>();
		}

		public int ClientRegistrationStatusId { get; set; }
		public string Name { get; set; }

		public virtual ICollection<ClientDal> Clients { get; set; }
	}
}
