using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class JuridicalRequisite
	{
		public JuridicalRequisite()
		{
			Clients = new HashSet<ClientDal>();
		}

		public long JuridicalRequisiteId { get; set; }
		public string ChiefName { get; set; }
		public string RepresenterName { get; set; }
		public long? SecondaryAddressId { get; set; }

		public virtual AddressDal SecondaryAddress { get; set; }
		public virtual ICollection<ClientDal> Clients { get; set; }
	}
}
