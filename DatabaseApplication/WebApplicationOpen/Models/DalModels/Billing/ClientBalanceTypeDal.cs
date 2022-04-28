using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.Clients;

namespace WebApplicationOpen.Models.DalModels.Billing
{
	[Table("ClientBalanceType")]
	public class ClientBalanceTypeDal
	{
		[Key]
		public int ClientBalanceTypeId { get; set; }
		public int BalanceTypeId { get; set; }
		public int ClientTypeId { get; set; }

		public virtual BalanceTypeDal BalanceType { get; set; }
		public virtual ClientTypeDal ClientType { get; set; }
	}
}
