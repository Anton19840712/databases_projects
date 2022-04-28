using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("JuridicalRequisite")]
	public sealed class JuridicalRequisiteDal
	{
		public JuridicalRequisiteDal()
		{
			Clients = new HashSet<ClientDal>();
		}
		[Key]
		public long JuridicalRequisiteId { get; set; }
		public string ChiefName { get; set; }
		public string RepresenterName { get; set; }
		public long? SecondaryAddressId { get; set; }

		public AddressDal SecondaryAddress { get; set; }
		public ICollection<ClientDal> Clients { get; set; }
	}
}
