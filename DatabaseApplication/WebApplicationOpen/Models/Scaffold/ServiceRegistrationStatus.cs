using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class ServiceRegistrationStatus
	{
		public ServiceRegistrationStatus()
		{
			ServiceRegistrations = new HashSet<ServiceRegistration>();
		}

		public int ServiceRegistrationStatusId { get; set; }
		public string Name { get; set; }

		public ICollection<ServiceRegistration> ServiceRegistrations { get; set; }
	}
}
