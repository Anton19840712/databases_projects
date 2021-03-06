using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationOpen.Models.DalModels.Clients;

namespace WebApplicationOpen.Models.DalModels.Billing
{
	[Table("DebitBalance")]
	public class DebitBalanceDal
	{
		[Key]
		public long DebitBalanceId { get; set; }
		public long ClientId { get; set; }
		public int BalanceTypeId { get; set; }
		public DateTime Created { get; set; }
		public decimal Value { get; set; }

		public virtual BalanceTypeDal BalanceType { get; set; }
		public virtual ClientDal Client { get; set; }
	}
}
