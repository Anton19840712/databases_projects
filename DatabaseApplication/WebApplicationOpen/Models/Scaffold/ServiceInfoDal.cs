using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
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
