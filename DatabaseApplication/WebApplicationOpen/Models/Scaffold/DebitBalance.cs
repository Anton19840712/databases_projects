using System;



namespace WebApplicationOpen.Models.Scaffold
{
	public class DebitBalance
	{
		public long DebitBalanceId { get; set; }
		public long ClientId { get; set; }
		public int BalanceTypeId { get; set; }
		public DateTime Created { get; set; }
		public decimal Value { get; set; }

		public virtual BalanceTypeDal BalanceType { get; set; }
		public virtual ClientDal Client { get; set; }
	}
}
