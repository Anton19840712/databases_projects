using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.TariffPlans
{
	[Table("VpsTariffPlanConfigLimits")]
	public class VpsTariffPlanConfigLimitDal
	{
		[Key]
		public long VpsTariffPlanConfigLimitId { get; set; }
		public int MaxCpuCoreCount { get; set; }
		public int MaxRamInMb { get; set; }
		public int MaxDrivesCount { get; set; }
		public int MaxIpAdressesCount { get; set; }
		public int MaxCapacityPerDriveInMb { get; set; }
		public int RamInMbChangeStep { get; set; }
		public int DriveCapacityInMbChangeStep { get; set; }
		public int MinCapacityPerDriveInMb { get; set; }
		public int MinIpAdressesCount { get; set; }
		public bool IsActive { get; set; }
	}
}
