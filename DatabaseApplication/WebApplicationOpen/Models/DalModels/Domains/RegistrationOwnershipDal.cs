using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.StateRegistration;

namespace WebApplicationOpen.Models.DalModels.Domains
{
	[Table("RegistrationOwnerships")]
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
