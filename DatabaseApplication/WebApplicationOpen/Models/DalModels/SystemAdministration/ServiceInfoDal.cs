using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.BaseTablesForServices;

namespace WebApplicationOpen.Models.DalModels.SystemAdministration
{
	[Table("ServiceInfo")]
	public class ServiceInfoDal
	{
		[Key]
		public long Id { get; set; }
		public long ServiceId { get; set; }
		public string Description { get; set; }

		public virtual ServiceDal Service { get; set; }
	}
}
