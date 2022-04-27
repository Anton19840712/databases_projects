using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("VpsConfig")]
	public sealed class VpsConfigDal
	{
		public VpsConfigDal()
		{
			Vps = new HashSet<VpDal>();
			VpsDrives = new HashSet<VpsDrifeDal>();
			VpsTariffPlans = new HashSet<VpsTariffPlanDal>();
		}

		public long VpsConfigId { get; set; }
		public int? OsTypeId { get; set; }
		public int CpuCores { get; set; }
		public int RamInMb { get; set; }
		public int ExternalIpAddress { get; set; }

		public VpsOsTypeDal OsType { get; set; }
		public ICollection<VpDal> Vps { get; set; }
		public ICollection<VpsDrifeDal> VpsDrives { get; set; }
		public ICollection<VpsTariffPlanDal> VpsTariffPlans { get; set; }
	}
}
