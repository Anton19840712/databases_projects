using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.BaseTablesForServices;

namespace WebApplicationOpen.Models.DalModels.Vps
{
	[Table("Vps")]
	public class VpDal
	{
		[Key]
		public long VpsId { get; set; }
		public long ServiceId { get; set; }
		public long VpsConfigId { get; set; }
		public long? VirtManagerVpsId { get; set; }
		public string VirtManagerName { get; set; }
		public bool IsBlockedByAdmin { get; set; }
		public string Comment { get; set; }

		public virtual ServiceDal Service { get; set; }
		public virtual VpsConfigDal VpsConfig { get; set; }
	}
}
