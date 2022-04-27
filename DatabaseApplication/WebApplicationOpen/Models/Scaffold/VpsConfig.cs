using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class VpsConfig
	{
		public VpsConfig()
		{
			Vps = new HashSet<Vp>();
			VpsDrives = new HashSet<VpsDrife>();
			VpsTariffPlans = new HashSet<VpsTariffPlan>();
		}

		public long VpsConfigId { get; set; }
		public int? OsTypeId { get; set; }
		public int CpuCores { get; set; }
		public int RamInMb { get; set; }
		public int ExternalIpAddress { get; set; }

		public VpsOsType OsType { get; set; }
		public ICollection<Vp> Vps { get; set; }
		public ICollection<VpsDrife> VpsDrives { get; set; }
		public ICollection<VpsTariffPlan> VpsTariffPlans { get; set; }
	}
}
