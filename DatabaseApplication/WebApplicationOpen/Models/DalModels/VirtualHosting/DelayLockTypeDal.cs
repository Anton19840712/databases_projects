using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationOpen.Models.DalModels.VirtualHosting
{
	[Table("DelayLockTypes")]
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
