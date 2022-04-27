

namespace WebApplicationOpen.Models.Scaffold
{
	public class Vp
	{
		public long VpsId { get; set; }
		public long ServiceId { get; set; }
		public long VpsConfigId { get; set; }
		public long? VirtManagerVpsId { get; set; }
		public string VirtManagerName { get; set; }
		public bool IsBlockedByAdmin { get; set; }
		public string Comment { get; set; }

		public virtual Service Service { get; set; }
		public virtual VpsConfig VpsConfig { get; set; }
	}
}
