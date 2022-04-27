using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class VpsOsType
	{
		public VpsOsType()
		{
			VpsConfigs = new HashSet<VpsConfig>();
		}

		public int VpsOsTypeId { get; set; }
		public string Uuid { get; set; }
		public string InternalName { get; set; }
		public string Name { get; set; }

		public virtual ICollection<VpsConfig> VpsConfigs { get; set; }
	}
}
