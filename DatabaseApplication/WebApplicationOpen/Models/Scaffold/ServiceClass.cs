using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class ServiceClass
	{
		public ServiceClass()
		{
			ServiceTypes = new HashSet<ServiceType>();
		}

		public int ServiceClassId { get; set; }
		public string Name { get; set; }

		public virtual ICollection<ServiceType> ServiceTypes { get; set; }
	}
}
