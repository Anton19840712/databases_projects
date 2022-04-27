using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("ServiceClass")]
	public sealed class ServiceClassDal
	{
		public ServiceClassDal()
		{
			ServiceTypes = new HashSet<ServiceTypeDal>();
		}

		public int ServiceClassId { get; set; }
		public string Name { get; set; }

		public ICollection<ServiceTypeDal> ServiceTypes { get; set; }
	}
}
