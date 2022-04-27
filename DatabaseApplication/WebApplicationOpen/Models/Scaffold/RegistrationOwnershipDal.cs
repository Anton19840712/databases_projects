using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("RegistrationOwnership")]
	public sealed class RegistrationOwnershipDal
	{
		public RegistrationOwnershipDal()
		{
			ServiceRegistrations = new HashSet<ServiceRegistrationDal>();
		}

		public int RegistrationOwnershipId { get; set; }
		public string Name { get; set; }

		public ICollection<ServiceRegistrationDal> ServiceRegistrations { get; set; }
	}
}
