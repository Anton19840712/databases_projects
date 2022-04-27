using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public sealed class BalanceTypeDal
	{
		public BalanceTypeDal()
		{
			ClientBalanceTypes = new HashSet<ClientBalanceTypeDal>();
			ClientBalances = new HashSet<ClientBalance>();
			DebitBalances = new HashSet<DebitBalance>();
		}

		public int BalanceTypeId { get; set; }
		public int CurrencyId { get; set; }

		public Currency Currency { get; set; }
		public ICollection<ClientBalanceTypeDal> ClientBalanceTypes { get; set; }
		public ICollection<ClientBalance> ClientBalances { get; set; }
		public ICollection<DebitBalance> DebitBalances { get; set; }
	}
}
