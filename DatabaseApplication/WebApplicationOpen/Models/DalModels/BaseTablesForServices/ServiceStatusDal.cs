using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.BaseTablesForServices
{
	[Table("ServiceStatuses")]
	public sealed class ServiceStatusDal
	{
		public ServiceStatusDal()
		{
			Services = new HashSet<ServiceDal>();
		}
		[Key]
		public int ServiceStatusId { get; set; }
		public string Description { get; set; }

		public ICollection<ServiceDal> Services { get; set; }
	}
}
