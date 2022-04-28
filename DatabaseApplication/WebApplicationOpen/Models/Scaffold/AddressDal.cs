using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("Address")]
	public sealed class AddressDal
	{
		public AddressDal()
		{
			Clients = new HashSet<ClientDal>();
			Registrants = new HashSet<RegistrantDal>();
		}

		[Key]
		public long AddressId { get; set; }
		public int CountryId { get; set; }
		public string ZipCode { get; set; }
		public string City { get; set; }
		public string Street { get; set; }
		public string District { get; set; }
		public string Building { get; set; }
		public string Room { get; set; }

		public CountryDal Country { get; set; }
		public JuridicalRequisiteDal JuridicalRequisite { get; set; }
		public ICollection<ClientDal> Clients { get; set; }
		public ICollection<RegistrantDal> Registrants { get; set; }
	}
}
