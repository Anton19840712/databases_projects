using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("VpsConfigItemsCost")]
	public class VpsConfigItemsCostDal
	{
		[Key]
		public long VpsConfigItemsCostId { get; set; }
		public int CurrencyId { get; set; }
		public decimal CpuCore { get; set; }
		public decimal RamPerMb { get; set; }
		public decimal HddPerMb { get; set; }
		public decimal SsdPerMb { get; set; }
		public decimal IpDefault { get; set; }
		public DateTime CreationDate { get; set; }
		public bool IsActive { get; set; }

		public virtual CurrencyDal Currency { get; set; }
	}
}
