using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("RegistrationOwnership")]
	public sealed class RegistrationOwnershipDal
	{
		public RegistrationOwnershipDal()
		{
			ServiceRegistrations = new HashSet<ServiceRegistrationDal>();
		}

		[Key]
		public int RegistrationOwnershipId { get; set; }
		public string Name { get; set; }

		public ICollection<ServiceRegistrationDal> ServiceRegistrations { get; set; }
	}
}
