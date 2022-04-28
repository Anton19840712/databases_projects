using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("DelayLockType")]
	public sealed class DelayLockTypeDal
	{
		public DelayLockTypeDal()
		{
			DelayLocks = new HashSet<DelayLockDal>();
		}

		[Key]
		public int DelayLockTypeId { get; set; }
		public string Description { get; set; }

		public ICollection<DelayLockDal> DelayLocks { get; set; }
	}
}
