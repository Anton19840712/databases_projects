using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.BaseTablesForServices;

namespace WebApplicationOpen.Models.DalModels.Common
{
	[Table("ServiceClasses")]
	public sealed class ServiceClassDal
	{
		public ServiceClassDal()
		{
			ServiceTypes = new HashSet<ServiceTypeDal>();
		}

		[Key]
		public int ServiceClassId { get; set; }
		public string Name { get; set; }

		public ICollection<ServiceTypeDal> ServiceTypes { get; set; }
	}
}
