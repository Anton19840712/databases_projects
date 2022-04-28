using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("VpsOsType")]
	public sealed class VpsOsTypeDal
	{
		public VpsOsTypeDal()
		{
			VpsConfigs = new HashSet<VpsConfigDal>();
		}

		[Key]
		public int VpsOsTypeId { get; set; }
		public string Uuid { get; set; }
		public string InternalName { get; set; }
		public string Name { get; set; }

		public ICollection<VpsConfigDal> VpsConfigs { get; set; }
	}
}
