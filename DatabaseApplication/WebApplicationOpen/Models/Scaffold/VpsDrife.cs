

namespace WebApplicationOpen.Models.Scaffold
{
	public class VpsDrife
	{
		public long VpsDriveId { get; set; }
		public long VpsConfigId { get; set; }
		public int DriveTypeId { get; set; }
		public int DriveCapacityInMb { get; set; }

		public virtual VpsDriveType DriveType { get; set; }
		public virtual VpsConfig VpsConfig { get; set; }
	}
}
