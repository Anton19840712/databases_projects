

namespace WebApplicationOpen.Models.Scaffold
{
	public class ClientBalance
	{
		public long ClientBalanceId { get; set; }
		public long ClientId { get; set; }
		public int BalanceTypeId { get; set; }
		public decimal Value { get; set; }
		public bool IsCurrent { get; set; }
		public decimal? CreditLimit { get; set; }

		public virtual BalanceTypeDal BalanceType { get; set; }
		public virtual ClientDal Client { get; set; }
	}
}
