using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.Clients
{
	[Table("JuridicalRequisites")]
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
