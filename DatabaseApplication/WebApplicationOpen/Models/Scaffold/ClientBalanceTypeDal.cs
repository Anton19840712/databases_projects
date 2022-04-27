using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("ClientBalanceType")]
	public class ClientBalanceTypeDal
	{
		public int ClientBalanceTypeId { get; set; }
		public int BalanceTypeId { get; set; }
		public int ClientTypeId { get; set; }

		public virtual BalanceTypeDal BalanceType { get; set; }
		public virtual ClientTypeDal ClientType { get; set; }
	}
}
