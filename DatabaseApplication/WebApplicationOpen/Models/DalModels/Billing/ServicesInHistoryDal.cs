using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.BaseTablesForServices;

namespace WebApplicationOpen.Models.DalModels.Billing
{
	[Table("ServicesInHistory")]
	public class ServicesInHistoryDal
	{
		[Key]
		public long ServicesInHistoryId { get; set; }
		public long ServiceId { get; set; }
		public long ServiceHistoryId { get; set; }

		public virtual ServiceDal Service { get; set; }
		public virtual ServiceHistoryDal ServiceHistory { get; set; }
	}
}
