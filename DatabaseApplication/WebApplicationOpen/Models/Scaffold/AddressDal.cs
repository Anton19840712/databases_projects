using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class AddressDal
	{
		public AddressDal()
		{
			Clients = new HashSet<ClientDal>();
			Registrants = new HashSet<Registrant>();
		}

		public long AddressId { get; set; }
		public int CountryId { get; set; }
		public string ZipCode { get; set; }
		public string City { get; set; }
		public string Street { get; set; }
		public string District { get; set; }
		public string Building { get; set; }
		public string Room { get; set; }

		public Country Country { get; set; }
		public JuridicalRequisite JuridicalRequisite { get; set; }
		public ICollection<ClientDal> Clients { get; set; }
		public ICollection<Registrant> Registrants { get; set; }
	}
}
