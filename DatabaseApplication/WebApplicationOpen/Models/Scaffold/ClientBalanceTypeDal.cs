using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
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
