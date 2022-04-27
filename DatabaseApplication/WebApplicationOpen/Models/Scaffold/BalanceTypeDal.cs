﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplicationOpen.Models.Scaffold
{
	[Table("BalanceType")]
	public sealed class BalanceTypeDal
	{
		public BalanceTypeDal()
		{
			ClientBalanceTypes = new HashSet<ClientBalanceTypeDal>();
			ClientBalances = new HashSet<ClientBalanceDal>();
			DebitBalances = new HashSet<DebitBalanceDal>();
		}

		public int BalanceTypeId { get; set; }
		public int CurrencyId { get; set; }

		public CurrencyDal Currency { get; set; }
		public ICollection<ClientBalanceTypeDal> ClientBalanceTypes { get; set; }
		public ICollection<ClientBalanceDal> ClientBalances { get; set; }
		public ICollection<DebitBalanceDal> DebitBalances { get; set; }
	}
}
