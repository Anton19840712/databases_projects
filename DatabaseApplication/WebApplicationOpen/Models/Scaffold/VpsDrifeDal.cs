using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("VpsDrife")]
	public class VpsDrifeDal
	{
		[Key]
		public long VpsDriveId { get; set; }
		public long VpsConfigId { get; set; }
		public int DriveTypeId { get; set; }
		public int DriveCapacityInMb { get; set; }

		public virtual VpsDriveTypeDal DriveType { get; set; }
		public virtual VpsConfigDal VpsConfig { get; set; }
	}
}
