using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("ServiceStatus")]
	public sealed class ServiceStatusDal
	{
		public ServiceStatusDal()
		{
			Services = new HashSet<ServiceDal>();
		}

		public int ServiceStatusId { get; set; }
		public string Description { get; set; }

		public ICollection<ServiceDal> Services { get; set; }
	}
}
