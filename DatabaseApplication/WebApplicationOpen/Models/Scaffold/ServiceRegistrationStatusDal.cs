using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("ServiceRegistrationStatus")]
	public sealed class ServiceRegistrationStatusDal
	{
		public ServiceRegistrationStatusDal()
		{
			ServiceRegistrations = new HashSet<ServiceRegistrationDal>();
		}

		public int ServiceRegistrationStatusId { get; set; }
		public string Name { get; set; }

		public ICollection<ServiceRegistrationDal> ServiceRegistrations { get; set; }
	}
}
