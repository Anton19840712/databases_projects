

namespace WebApplicationOpen.Models.Scaffold
{
	public class ClientBalanceTypeDal
	{
		public int ClientBalanceTypeId { get; set; }
		public int BalanceTypeId { get; set; }
		public int ClientTypeId { get; set; }

		public virtual BalanceTypeDal BalanceType { get; set; }
		public virtual ClientType ClientType { get; set; }
	}
}
