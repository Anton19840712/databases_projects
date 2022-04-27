using System.Collections.Generic;



namespace WebApplicationOpen.Models.Scaffold
{
	public class DelayLockType
	{
		public DelayLockType()
		{
			DelayLocks = new HashSet<DelayLock>();
		}

		public int DelayLockTypeId { get; set; }
		public string Description { get; set; }

		public virtual ICollection<DelayLock> DelayLocks { get; set; }
	}
}
