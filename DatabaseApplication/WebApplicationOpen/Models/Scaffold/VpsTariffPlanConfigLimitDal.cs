using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplicationOpen.Models.Scaffold
{
	[Table("VpsTariffPlanConfigLimit")]
	public class VpsTariffPlanConfigLimitDal
	{
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
