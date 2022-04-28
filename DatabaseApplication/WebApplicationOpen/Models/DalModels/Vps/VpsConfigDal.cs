using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.TariffPlans;

namespace WebApplicationOpen.Models.DalModels.Vps
{
	[Table("VpsConfigs")]
	public sealed class VpsConfigDal
	{
		public VpsConfigDal()
		{
			Vps = new HashSet<VpDal>();
			VpsDrives = new HashSet<VpsDriveDal>();
			VpsTariffPlans = new HashSet<VpsTariffPlanDal>();
		}

		[Key]
		public long VpsConfigId { get; set; }
		public int? OsTypeId { get; set; }
		public int CpuCores { get; set; }
		public int RamInMb { get; set; }
		public int ExternalIpAddress { get; set; }

		public VpsOsTypeDal OsType { get; set; }
		public ICollection<VpDal> Vps { get; set; }
		public ICollection<VpsDriveDal> VpsDrives { get; set; }
		public ICollection<VpsTariffPlanDal> VpsTariffPlans { get; set; }
	}
}
