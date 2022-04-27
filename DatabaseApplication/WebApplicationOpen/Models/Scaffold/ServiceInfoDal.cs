using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("ServiceInfo")]
	public class ServiceInfoDal
	{
		public long Id { get; set; }
		public long ServiceId { get; set; }
		public string Description { get; set; }

		public virtual ServiceDal Service { get; set; }
	}
}
