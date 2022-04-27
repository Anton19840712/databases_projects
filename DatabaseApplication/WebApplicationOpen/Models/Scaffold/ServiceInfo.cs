

namespace WebApplicationOpen.Models.Scaffold
{
	public class ServiceInfo
	{
		public long Id { get; set; }
		public long ServiceId { get; set; }
		public string Description { get; set; }

		public virtual Service Service { get; set; }
	}
}
