using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.StateRegistration
{
	[Table("ServiceRegistrationStatuses")]
	public sealed class ServiceRegistrationStatusDal
	{
		public ServiceRegistrationStatusDal()
		{
			ServiceRegistrations = new HashSet<ServiceRegistrationDal>();
		}

		[Key]
		public int ServiceRegistrationStatusId { get; set; }
		public string Name { get; set; }

		public ICollection<ServiceRegistrationDal> ServiceRegistrations { get; set; }
	}
}
