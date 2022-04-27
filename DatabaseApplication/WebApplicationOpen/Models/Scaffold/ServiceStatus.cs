using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class ServiceStatus
	{
		public ServiceStatus()
		{
			Services = new HashSet<Service>();
		}

		public int ServiceStatusId { get; set; }
		public string Description { get; set; }

		public ICollection<Service> Services { get; set; }
	}
}
